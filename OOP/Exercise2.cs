using System;

namespace Exercise2
{
	public class PhotoAlbum
	{
		public int pagesNumber {set; get;}
		public PhotoAlbum()
		{
			this.pagesNumber = 16;
		}

		public PhotoAlbum(int pagesNumber)
		{
			this.pagesNumber = pagesNumber;
		}

		public int NumberOfPages()
		{
			return pagesNumber;
		}
	}

	public class BigPhotoAlbum
	{
		public int bigPhotoNumber{set; get;}

		public BigPhotoAlbum()
		{
			this.bigPhotoNumber = 64;
		}

	}

	public class Exercise2
	{
		public static void SMMain(string[] args)
		{
			PhotoAlbum photo = new PhotoAlbum();
			System.Console.WriteLine(photo.pagesNumber);
			BigPhotoAlbum bigPhoto = new BigPhotoAlbum();
			System.Console.WriteLine(bigPhoto.bigPhotoNumber);
		}
	}
}