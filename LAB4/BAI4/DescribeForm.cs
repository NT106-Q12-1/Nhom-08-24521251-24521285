using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI4
{
    public partial class DescribeForm : Form
    {
        ImageList imgList = new ImageList();
        List<Main.Movie> movies;
        public DescribeForm(List<Main.Movie> list)
        {
            InitializeComponent();
            this.movies = list;
            MovieShowList.Clear();
            ShowingMovie(movies);
            this.MovieShowList.MouseClick += MovieNowShowing_MouseClick;

        }

        public void ShowingMovie(List<Main.Movie> Movies)
        {
            imgList.Images.Clear();
            imgList.ImageSize = new Size(90, 120);
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            MovieShowList.Items.Clear();
            MovieShowList.View = View.Details;
            MovieShowList.GridLines = true;
            MovieShowList.FullRowSelect = true;


            if (MovieShowList.Columns.Count == 0)
            {
                MovieShowList.Columns.Clear();
                MovieShowList.Columns.Add("Ảnh & Tên Phim", 400);
                MovieShowList.Columns.Add("Đường dẫn", Width);
            }

            int imgIndex = 0;
            WebClient webClient = new WebClient();
            foreach (var movie in Movies)
            {
                Image poster = null;
                try
                {
                    byte[] bytes = webClient.DownloadData(movie.PosterURL);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        poster = Image.FromStream(ms);
                    }

                }
                catch
                {
                    poster = new Bitmap(100, 150);
                }
                imgList.Images.Add(poster);

                ListViewItem item = new ListViewItem();
                item.Text = movie.Title;
                item.ImageIndex = imgIndex;

                item.SubItems.Add(movie.DetailURL);

                item.Tag = movie;

                MovieShowList.Items.Add(item);
                imgIndex++;
            }
            MovieShowList.SmallImageList = imgList;
        }

        private void MovieNowShowing_MouseClick(object sender, MouseEventArgs e)
        {
            string url = MovieShowList.SelectedItems[0].SubItems[1].Text;
            new WebMovies(url).Show();
        }
    }
 }
    
