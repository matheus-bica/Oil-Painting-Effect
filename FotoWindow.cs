using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFPI
{
    public partial class FotoWindow : Form
    {
        //private ImgBitmap imagemFoto;
        public FotoWindow(Image novaImagem)
        {
            InitializeComponent();
            this.getImagem().imagem = (Bitmap)novaImagem;
            this.pictureBox.Image = getImagem().getImagem();
            this.Size = novaImagem.Size;
        }

        public FotoWindow()
        {
            InitializeComponent();
        }


        public void carregaImagem(Image novaImagem)
        {
            this.pictureBox.Image = novaImagem;
            this.Size = novaImagem.Size;
        }

        public ImgBitmap getImagem()
        {
            return new ImgBitmap((Bitmap) this.pictureBox.Image);
        }

        public Bitmap getImagem2()
        {
            return (Bitmap)this.pictureBox.Image;
        }
    }
}
