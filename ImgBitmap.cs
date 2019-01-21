using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Drawing;

namespace TrabalhoFPI 
{
     public class ImgBitmap : ICloneable
    {
        private String endereco = "";
        private Boolean valido = false;
        public Bitmap imagem;
        private Boolean BlackWhite;

        public ImgBitmap(String endereco)
        {
            // Open a Stream and decode a JPEG image
            try
            {
                this.endereco = endereco;
                this.imagem = new Bitmap(Image.FromFile(endereco));
                this.valido = true;

                if (imagem == null)
                    this.valido = false;


            }
            catch (Exception ex)
            {
                this.valido = false;
            }
            

        }

        public ImgBitmap(Bitmap imagem)
        {
            // Open a Stream and decode a JPEG image
            try
            {
                
                this.imagem = imagem;
                this.endereco = "";
                this.valido = true;
                if (imagem == null)
                    this.valido = false;


            }
            catch (Exception ex)
            {
                this.valido = false;
            }


        }

        public object Clone()
        {
            ImgBitmap novaImg = new ImgBitmap(this.imagem);

            novaImg.endereco = this.endereco;
            novaImg.valido = this.valido;

            return novaImg;
        }

        public void setImagem(Bitmap imagemN)
        {
            this.imagem = imagemN;
        }

        public Bitmap getImagem()
        {
            return this.imagem;
        }


    }
}