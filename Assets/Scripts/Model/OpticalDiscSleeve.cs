namespace BoxArt.Model
{
	[System.Serializable]
	public class OpticalDiscSleeve
	{
		public Color color; // paper color
		public string frontImage;
		public string backImage;
		public bool hasFlap; // closes at the top
		public bool hasWindow; // transparent window showing the disc
		public OpticalDisc disc;
	}
}
