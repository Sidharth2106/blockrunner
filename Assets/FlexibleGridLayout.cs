using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class FlexibleGridLayout : MonoBehaviour
{
    public int rows = 2;
    public int columns = 5;
    private GridLayoutGroup grid;

    void Awake()
    {
        grid = GetComponent<GridLayoutGroup>();
        ResizeCells();
    }

    void Update()
    {
        ResizeCells();
    }

    void ResizeCells()
    {
        RectTransform rt = GetComponent<RectTransform>();
        float parentWidth = rt.rect.width;
        float parentHeight = rt.rect.height;

        float cellWidth = (parentWidth / columns) - grid.spacing.x;
        float cellHeight = (parentHeight / rows) - grid.spacing.y;

        grid.cellSize = new Vector2(cellWidth, cellHeight);
    }
}
