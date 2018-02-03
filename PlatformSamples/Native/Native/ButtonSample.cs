using Ooui;

namespace Native
{
    public class ButtonSample
    {
        public static ButtonSample Default { get; } = new ButtonSample();
        ButtonSample() {}

        public Element Get()
        {
            var button = new Button("Click me!")
                         {
                             ClassName = "btn btn-primary",
                             Style = {MarginTop = "2em"}, // Some bootstrap styling
                         };
            var count = 0;
            button.Click += (s, e) => {
                                count++;
                                button.Text = $"Clicked {count} times";
                            };
            return button;
        }
    }
}


