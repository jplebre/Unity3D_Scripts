using UnityEngine;

public class ViewPortInPicture: MonoBehaviour
{

	//let's create a variable for the position of the new window
	//we use enum so we encapsulate several variables
	public enum HorizontalAlignment{left, center, right};
	public enum VerticalAlignment{top, middle, bottom};

	//creating a variable from the enum. 
	//the type is the actual created enum: HorizontalAlignment or VerticalAlignment

	public HorizontalAlignment horizontalAlignment = HorizontalAlignment.left;
	public VerticalAlignment verticalAlignment = VerticalAlignment.top;

	//Let's do the same for the size of the window
	public enum ScreenDimensions{pixels, screen_percentage};
	public ScreenDimensions dimensionsIn = ScreenDimensions.pixels;

	public int width = 50;
	public int height = 50;
	public float xOffset = 0f;
	public float yOffset = 0f;

	//will check for bool and used by Update() 
	public bool update = true;

	//Instatiating variables to be used in AdjustCamera()
	private int hsize, vsize, hloc, vloc ;

	//starts the script
	void Start(){ AdjustCamera(); }

	//updates every frame (monobehaviour.update()
	void Update()
	{
		if (update)
			AdjustCamera();
	}

	void AdjustCamera()
	{
		//let's start by check if the pixels and size match.
		//If not, make them match
		if (dimensionsIn == ScreenDimensions.screen_percentage)
		{
			hsize = Mathf.RoundToInt (width * 0.01f * Screen.width);
			vsize = Mathf.RoundToInt (height * 0.01f * Screen.height);
		}
		else
		{
			hsize = width;
			vsize = height;
		}


		//Depending on which enum is selected: left, right or center
		//Position the screen. Round to closest int and use Screen.Width to find out resolution/screen size
		if (horizontalAlignment == HorizontalAlignment.left)
		{
			hloc = Mathf.RoundToInt(xOffset * 0.01f * Screen.width);
		}
		else if (horizontalAlignment == HorizontalAlignment.right)
		{
			hloc = Mathf.RoundToInt((Screen.width - hsize) - (xOffset * 0.01f * Screen.width));
		}
		else
		{
			hloc = Mathf.RoundToInt(((Screen.width * 0.5f) - (hsize * 0.5f)) - (xOffset * 0.01f * Screen.width));
		}


		if (verticalAlignment == VerticalAlignment.top)
		{
			vloc = Mathf.RoundToInt((Screen.height - vsize) - (yOffset * 0.01f * Screen.height));
		}
		else if (verticalAlignment == VerticalAlignment.bottom)
		{
			vloc = Mathf.RoundToInt(yOffset * 0.01f * Screen.height);
		}
		else
		{
			vloc = Mathf.RoundToInt(((Screen.height * 0.5f) - (vsize * 0.5f)) - (yOffset * 0.01f * Screen.height));
		}

		//set camera.pixelRect with a new position for the camera rectangle
		camera.pixelRect = new Rect(hloc,vloc,hsize,vsize);
	}
}

