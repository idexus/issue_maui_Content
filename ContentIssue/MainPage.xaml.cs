namespace ContentIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (this.Parent is ShellContent shellContent)
		{
			var contentPage = new ContentPage();
			var label = new Label();

			label.Text = "Page changed";
			label.FontSize = 30;
			label.HorizontalOptions = LayoutOptions.Center;
			label.VerticalOptions = LayoutOptions.Center;
			contentPage.Content = label;

            shellContent.ContentTemplate = null;
            shellContent.Content = contentPage;

			// there is no way to reload current page
        }
	}
}
