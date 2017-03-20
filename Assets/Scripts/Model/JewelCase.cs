namespace BoxArt.Model
{
	public enum JewelCaseType
	{
		Standard, // audio CD case, 142 x 125 x 10 mm
		Slimline, // thin, only supports one disc, 142 x 125 x 5 mm
		Clamshell, // round
	}

	public class JewelCase
	{
		public string coverImage;
		public string behindDiscImage;
		public string backInsertImage;
		public string spineInsertImage; // if set, adds a paper insert in the spine
		public bool hasSolidSpine; // If true, spine is a solid piece of black plastic, otherwise it's transparent and may have an insert image
		public OpticalDisc[] discs; // case grows as discs are added
	}
}
