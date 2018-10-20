using System;
using System.Windows.Forms;

public class Hello : Form
{

	static void Main(){
	
		Application.Run(new Hello());

	}

	public Hello(){
		Text = "Hello Mono Form";
	}

}
