namespace BoxArt.Model
{
	public enum BookletBindingType {
		Staple, // 
		Glue, // flat spine
		Spiral, // metal spiral
		Comb // plastic spiral
	}

	[System.Serializable]
	public class Booklet
	{
		public BookletBindingType bindingType;
		public Color bindingColor; // If not set, the binding will be the native material such as black plastic or steel
		public string[] pageImages;
	}
}
