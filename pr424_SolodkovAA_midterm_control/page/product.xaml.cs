using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr424_SolodkovAA_midterm_control.page
{
	/// <summary>
	/// Логика взаимодействия для product.xaml
	/// </summary>
	public partial class product : Page
	{
		int id = 0;
		List<Product> product_db = new List<Product>();

		void test_db()
		{
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский 6888", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 3", Type = "5", Artucyl = 80007300, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 4", Type = "5", Artucyl = 82925345, Price = 19319 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 5", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик для мальчиков 3929", Type = "5", Artucyl = 82923345, Price = 1319 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 7", Type = "5", Artucyl = 82945345, Price = 1319 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 8", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 9", Type = "5", Artucyl = 823925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 10", Type = "5", Artucyl = 82934345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 11", Type = "5", Artucyl = 74291677, Price = 1319 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 12", Type = "5", Artucyl = 83925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 13", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 14", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 15", Type = "5", Artucyl = 82925345, Price = 1919 });

			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый 6678", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый  1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый  1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтый 1289", Type = "5", Artucyl = 8329345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский желтыйй 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82425345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82995345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82955345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82725345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82825345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });

			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 3", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82225345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82025345, Price = 1219 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82923345, Price = 1319 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82425345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 81925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82945345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });

			product_db.Add(new Product() { Id = 1, Name = "Попрыгунчик детский красный 1289", Type = "5", Artucyl = 82925345, Price = 1919 });
		}

		public product(int ids)
		{
			InitializeComponent();
			id = ids;

			glav.WindowTitle = "Продукция - страница " + System.Convert.ToString(id + 1);
			glav.Title = "Продукция - страница " + System.Convert.ToString(id + 1);

			test_db();

			List<Product> product_page = new List<Product>();
			for (int i = id * 15; i < product_db.Count; i++)
			{
				if (i >= (id + 1) * 15)
				{
					break;
				}
				product_page.Add(product_db[i]);
			}

			dbproduct.ItemsSource = product_page;

			nomer.Content = id + 1;
			if (!(product_db.Count - 15 * (id + 1) > 0))
			{
				dal.Visibility = Visibility.Hidden;
			}
			if (!(id - 1 >= 0))
			{
				nazad.Visibility = Visibility.Hidden;
			}
		}
		public product()
		{
			InitializeComponent();

			test_db();

			glav.WindowTitle = "Продукция - страница " + System.Convert.ToString(id + 1);
			glav.Title = "Продукция - страница " + System.Convert.ToString(id + 1);

			List<Product> product_page = new List<Product>();
			for (int i = id * 15; i < product_db.Count; i++)
			{
				if (i>= (id+1) * 15)
				{
					break;
				}
				product_page.Add(product_db[i]);
			}

			dbproduct.ItemsSource = product_page;
			nomer.Content = id + 1;
			if (!(product_db.Count - 15 * (id + 1) > 0))
			{
				dal.Visibility = Visibility.Hidden;
			}
			if (!(id - 1 >= 0))
			{
				nazad.Visibility = Visibility.Hidden;
			}
		}
		public class Product
		{
			public int Id { get; set; }
			public string Name { get; set; }
			public string Type { get; set; }
			public int Artucyl { get; set; }
			public float Price { get; set; }
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//NavigationService.Navigate(new product(0));
		}

		private void dal_Click(object sender, RoutedEventArgs e)
		{
			if (product_db.Count - 15*(id+1) > 0)
			{
				NavigationService.Navigate(new product(id + 1));
			}
		}

		private void nazad_Click(object sender, RoutedEventArgs e)
		{
			if (id - 1 >= 0)
			{
				NavigationService.Navigate(new product(id - 1));
			}
		}
	}
}
