namespace BoxArt.Model
{
	public enum BoxType
	{
		Standard, // opens at the top to access contents
		FrontFlap, // opens to show marketing material, contents accessed from the top
		LidBox, // lid pulls off, revealing tray with contents
		BoxSleeve, // outer sleeve pulls off, revealing box that can be pulled apart to reveal the tray
	}

	[System.Serializable]
	public class Faces
	{
		public Material front;
		public Material back;
		public Material left;
		public Material right;
		public Material top;
		public Material bottom;
	}

	[System.Serializable]
	public class Box
	{
		public BoxType boxType;
		public Size size; // cm
		public Faces faces;
	}
}
