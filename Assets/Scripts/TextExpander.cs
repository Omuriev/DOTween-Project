using DG.Tweening;

public class TextExpander : TextChanger
{
    private void Start()
    {
        Text.DOText(TextValue, Duration).SetRelative();
    }
}
