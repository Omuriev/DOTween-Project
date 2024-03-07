using DG.Tweening;

public class TextHacker : TextChanger
{
    private void Start()
    {
        Text.DOText(TextValue, Duration, true, ScrambleMode.All);
    }
}
