namespace BoxArt.Model
{
	public enum FloppySize {
		Floppy8, // 8" floppy
		Floppy525, // 5 1/4" floppy
		Floppy35, // 3 1/2" floppy
	}

	public enum FloppyLabelType {
		Standard, // Label fills the label region on the front of the disk
		Wrap, // Label wraps over the top of the disk
	}

	[System.Serializable]
	public class FloppyDisk
	{
		public FloppySize size;
		public Color color;
		public string labelImage;
	}
}
