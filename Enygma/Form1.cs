using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enygma
{

    public partial class Enygma : Form
    {


        CspParameters cspp = new CspParameters();
        RSACryptoServiceProvider rsa;

        //Variáveis para o "source", criptografia e descriptografia. Todas devem terminar com contra-barra
        const string EncrFolder = @"c:\Encrypt\";
        const string DecrFolder = @"c:\Decrypt\";
        const string SrcFolder = @"c:\docs\";

        //Arquivo em que a chave publica será gerado
        const string PubKeyFile = @"c:\encrypt\rsaPublicKey.txt";

        //Chave para fazer a criptografia, depois será implementado um input para o usuário digitar a chave
        const string keyName = "Key01";

        public Enygma()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Método para criptografar os arquivos
        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("Chave não definida");
            }
            else
            {
                //Mostra uma caixa de diálogo para selecionar o arquivo que vai ser criptografado
                openFileDialogEncrypt.InitialDirectory = SrcFolder;
                if(openFileDialogEncrypt.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialogEncrypt.FileName;
                    //Verifica se a variável possui valor
                    if (fileName != null)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        //Passa o nome do arquivo sem o diretório em que ele se encontra
                        string name = fileInfo.FullName;
                        Directory.CreateDirectory(EncrFolder);//Cria o diretório de arquivos Criptografados
                        EncryptFile(name);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível criptografar o arquivo!");
                    }
                }
            }
        }

        //Método para criptografar o arquivo
        private void EncryptFile(string inFile)
        {
            //Cria a instância do AES para a criptografia simétrica do dado
            Aes aes = Aes.Create();
            ICryptoTransform transform = aes.CreateEncryptor();

            //Usa RSACryptoServiceProvider para criptografar a chave AES
            byte[] keyEncrypted = rsa.Encrypt(aes.Key, false);

            //Cria os arrays para armazenar os valores de tamanho da chave e IV
            byte[] LenKey = new byte[4];
            byte[] LenIV = new byte[4];

            int lKey = keyEncrypted.Length;
            LenKey = BitConverter.GetBytes(lKey);
            int lIV = aes.IV.Length;
            LenIV = BitConverter.GetBytes(lIV);

            int startFileName = inFile.LastIndexOf("\\") + 1;
            //Muda a extensão do arquivo para '.enc'
            string outFile = EncrFolder + inFile.Substring(startFileName, inFile.LastIndexOf(".") - startFileName) + ".enc";

            using (FileStream outFs = new FileStream(outFile, FileMode.Create))
            {
                outFs.Write(LenKey, 0, 4); //Tamanho da chave
                outFs.Write(LenIV, 0, 4); //Tamanho do IV
                outFs.Write(keyEncrypted, 0, lKey); //Chave criptografada
                outFs.Write(aes.IV, 0, lIV); //O conteúdo da cifra

                //Escreve o conteúdo da cifra usando o CryptoStream para criptografar
                using(CryptoStream outStreamEncrypted = new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];
                    int bytesRead = 0;

                    using (FileStream inFs = new FileStream(inFile, FileMode.Open))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamEncrypted.Write(data, 0, count);
                            bytesRead += blockSizeBytes;
                        }
                        while (count < 0);
                        inFs.Close();
                    }
                    outStreamEncrypted.FlushFinalBlock();
                    outStreamEncrypted.Close();
                }
                outFs.Close();
            }

        }

        //Método para criar as chaves públicas e privadas utilizando a variável "keyName"
        private void btnCreateKeys_Click(object sender, EventArgs e)
        {
            cspp.KeyContainerName = keyName;
            rsa = new RSACryptoServiceProvider(cspp);
            rsa.PersistKeyInCsp = true;
            if (rsa.PublicOnly == true)
            {
                labelMessage.Text = "Key: " + cspp.KeyContainerName + " - Public Only";
                labelMessage.ForeColor = Color.White;
            }
            else
            {
                labelMessage.Text = "Key: " + cspp.KeyContainerName + " - Public Only";
                labelMessage.ForeColor = Color.White;
            }
        }

        //Descriptografa um arquivo
        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            if (rsa == null)
            {
                MessageBox.Show("A chave não foi criada");
            }
            else
            {
                openFileDialogDecrypt.InitialDirectory = EncrFolder;
                if (openFileDialogDecrypt.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialogEncrypt.FileName;
                    if(fileName != null)
                    {
                        FileInfo fileInfo = new FileInfo(fileName);
                        string name = fileInfo.Name;
                        DecryptFile(name);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível descriptografar o arquivo");
                    }
                }
            }
        }

        private void DecryptFile(string inFile)
        {
            Aes aes = Aes.Create();

            byte[] LenKey = new byte[4];
            byte[] LenIV = new byte[4];


            string outfile = DecrFolder + inFile.Substring(0, inFile.LastIndexOf(".")) + ".txt";

            using (FileStream inFs = new FileStream(DecrFolder + inFile, FileMode.Open))
            {
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenKey, 0, 3);
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);

                int lenK = BitConverter.ToInt32(LenKey, 0);
                int lenIV = BitConverter.ToInt32(LenIV, 0);

                int startC = lenK + lenIV + 8;
                int lenC = (int)inFs.Length - startC;

                byte[] KeyEcrypted = new byte[lenK];
                byte[] IV = new byte[lenIV];

                inFs.Seek(8, SeekOrigin.Begin);
                inFs.Seek(8 + lenK, SeekOrigin.Begin);
                inFs.Read(KeyEcrypted, 0, lenK);
                inFs.Read(IV, 0, lenIV);

                byte[] KeyDecrypted = rsa.Decrypt(KeyEcrypted, false);

                ICryptoTransform transform = aes.CreateDecryptor(KeyDecrypted, IV);

                using (FileStream outFs = new FileStream(outfile, FileMode.Create))
                {
                    int count = 0;
                    int offset = 0;

                    int blockSizeBytes = aes.BlockSize / 8;
                    byte[] data = new byte[blockSizeBytes];

                    inFs.Seek(startC, SeekOrigin.Begin);
                    using(CryptoStream outStreamDecrypted =  new CryptoStream(outFs, transform, CryptoStreamMode.Write))
                    {
                        do
                        {
                            count = inFs.Read(data, 0, blockSizeBytes);
                            offset += count;
                            outStreamDecrypted.Write(data, 0, count);
                        }
                        while (count < 0);

                        outStreamDecrypted.FlushFinalBlock();
                        outStreamDecrypted.Close();
                    }

                    outFs.Close();
                }
                inFs.Close();
            }
        }

        private void fileExtension_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
