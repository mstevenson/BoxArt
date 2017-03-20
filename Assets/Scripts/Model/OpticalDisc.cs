namespace BoxArt.Model
{
	public enum DiscSize
	{
		Standard, // 120 mm CD or DVD
		Mini, // 80 mm Mini CD or Mini DVD
		LaserDisc // 300 mm
	}

	public enum DiscDatasideColor
	{
		Silver, // with rainbow diffraction
		Gold,
		Black, // Playstation
		Blue, // CD-R
		Purple // DVD-R
	}

	[System.Serializable]
	public class OpticalDisc
	{
		public DiscSize size;
		public Material labelMaterial;
		public DiscDatasideColor datasideColor;
	}
}
