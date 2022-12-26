using ADOPMAUI_ExerciseAnswers.Models;

namespace ADOPMAUI_ExerciseAnswers.Views.Lesson02;


public partial class MarkupExtension1 : ContentPage
{
	int _idx = 0;
	List<NamedColor> _colors = NamedColor.All.ToList();

	public MarkupExtension1()
	{
		InitializeComponent();
        lblColorBox.Color = _colors[_idx % 5].Color;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _idx++;
        lblColorBox.Color = _colors[_idx % 5].Color;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }
}