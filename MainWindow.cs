using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoFPI
{
    public partial class MainWindow : Form
    {
        private FotoWindow fotoOriginal;
        private FotoWindow fotoEditada;
        public MainWindow()
        {
            InitializeComponent();
            fotoOriginal = new FotoWindow();
            fotoEditada = new FotoWindow();
            fotoEditada.Show();
            fotoOriginal.Show();
            fotoOriginal.Text = "Foto Original";
            fotoEditada.Text = "Foto Editada";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonNovaImagem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "Desktop";
            openFileDialog.Filter = "jpeg files (*.jpeg)|*.jpeg|(*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    /*pictureBoxOriginal.Image = new ImgBitmap(openFileDialog.FileName).imagem;
                    pictureBoxModificada.Image = new ImgBitmap(openFileDialog.FileName).imagem;*/
                    ImgBitmap aux = new ImgBitmap(openFileDialog.FileName);
                    fotoOriginal.carregaImagem(aux.imagem);
                    fotoEditada.carregaImagem(aux.imagem);
                    

                }
                catch (Exception ex)
                {
                }
            }

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = "Desktop";
            saveFileDialog.Filter = "jpeg files (*.jpeg)|*.jpeg|(*.jpg)|*.jpg";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string path = saveFileDialog.FileName;
                    //pictureBoxModificada.Image.Save(path);
                    fotoEditada.pictureBox.Image.Save(saveFileDialog.FileName);
                    //fotoEditada.getImagem(); //.getImagem().Save(path);

                }
                catch (Exception ex)
                {
                }
            }


        }


        private void buttonEffect_Click(object sender, EventArgs e)
        {
            labelPronto.Visible = false;


            fotoEditada.carregaImagem(OilPaintEffect.CreateEffect(fotoOriginal.getImagem2(), (int)RadiusNUD.Value, (int)IntensityNUD.Value));

            labelPronto.Visible = true;

        }



        

       

        
    }
}
