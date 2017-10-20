using System;

using UIKit;

namespace BMICalculator
{
    public partial class ViewController : UIViewController
    {

        public ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

    public override void ViewDidLoad()
    {
            base.ViewDidLoad();
        // Perform any additional setup after loading the view, typically from a nib.

            CalculateButton.TouchUpInside+= CalculateButton_TouchUpInside1;

    }

        void CalculateButton_TouchUpInside1(object sender, EventArgs e)
        {
			float height = float.Parse(heightTextField.Text);

			float weight = float.Parse(weightTextField.Text);



			float bmi = (weight / (height * height));


			bmiLabel.Text = bmi.ToString();
        }


    public override void DidReceiveMemoryWarning()
    {

            base.DidReceiveMemoryWarning();
        // Release any cached data, images, etc that aren't in use.
        }

        public override void TouchesBegan(Foundation.NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            this.View.EndEditing(true);
        }
}


}
