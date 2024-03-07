using DG.Tweening;

public class TextReplacer : TextChanger
{
    private void Start()
    {
        Text.DOText(TextValue, Duration);
    }
}
