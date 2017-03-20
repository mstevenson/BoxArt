namespace BoxArt.Model
{
	public enum DVDCaseType
	{
		Standard, // commercial DVD case
		Slim // half thickness
	}

	public class DVDCase
	{
		public DVDCaseType caseType;
		public Color color; // case plastic color
		public Material coverMaterial; // if set, adds a paper insert in the spine
		public OpticalDisc[] discs; // case grows as discs are added
	}
}
