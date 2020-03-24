using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace DecoratorPhoto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ////////////////////////////////////////////////////////////
            // Draws a single photograph in a window of fixed size
            // Has decorators that are BorderedPhotos and TaggedPhotos
            // that can be composed and added in different combinations
            ////////////////////////////////////////////////////////////

            // Application.Run acts as a simple client
            Photo photo;
            TaggedPhoto drinkTaggedPhoto, 
                        colorTaggedPhoto, 
                        tag;
            BorderedPhoto composition;


            // Compose a photo with two TaggedPhotos and a blue BorderedPhoto
            photo = new Photo();
            Application.Run(photo);
            drinkTaggedPhoto = new TaggedPhoto(photo, "Fresh drink");
            colorTaggedPhoto = new TaggedPhoto(drinkTaggedPhoto, "Orange");
            composition = new BorderedPhoto(colorTaggedPhoto, Color.Blue);
            Application.Run(composition);

            Console.WriteLine(colorTaggedPhoto.ListTaggedPhotos());

            // Compose a photo with one TaggedPhoto and a yellow BorderedPhoto
            photo = new Photo();
            tag = new TaggedPhoto(photo, "Plastic cup");
            composition = new BorderedPhoto(tag, Color.Yellow);
            Application.Run(composition);

            Console.WriteLine(tag.ListTaggedPhotos());
        }
    }
}

////////////////////////////////////////////////////////////////////
//IComponent --> Any photo
//Component  --> A plain photo
//Operation  --> To display a photo
//Decorator  --> A tagged photo
//Client     --> Creator of photos and tagged photos







