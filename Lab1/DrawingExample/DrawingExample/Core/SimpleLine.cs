using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LineDraw
{
    public class Line
    {
        public Vector2 startPoint = Vector2.Zero;
        public Vector2 endPoint = Vector2.Zero;
        public float width = 2.0f;
        public Color color = Color.White;

        // constructors
        public Line()
        {
            // Default constructor
        }
        public Line(Vector2 start, Vector2 end)
        {
            startPoint = start;
            endPoint = end;
        }
        public Line(Vector2 start, Vector2 end, float Width)
        {
            startPoint = start;
            endPoint = end;
            width = Width;
        }
        public Line(Vector2 start, Vector2 end, Color LineColor)
        {
            startPoint = start;
            endPoint = end;

            color = LineColor;
        }
        public Line(Vector2 start, Vector2 end, float Width, Color LineColor)
        {
            startPoint = start;
            endPoint = end;
            width = Width;
            color = LineColor;
        }
        public Line(float startX, float startY, float endX, float endY)
        {
            startPoint = new Vector2(startX, startY);
            endPoint = new Vector2(endX, endY);
        }
        public Line(float startX, float startY, float endX, float endY, float Width)
        {
            startPoint = new Vector2(startX, startY);
            endPoint = new Vector2(endX, endY);
            width = Width;
        }
        public Line(float startX, float startY, float endX, float endY, Color LineColor)
        {
            startPoint = new Vector2(startX, startY);
            endPoint = new Vector2(endX, endY);
            color = LineColor;
        }
        public Line(float startX, float startY, float endX, float endY, float Width, Color LineColor)
        {
            startPoint = new Vector2(startX, startY);
            endPoint = new Vector2(endX, endY);
            width = Width;
            color = LineColor;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            LineDrawer.DrawLine(spriteBatch, width, color, startPoint, endPoint);
        }

        public float Length()
        {
            return ((endPoint - startPoint).Length());
        }

        public void Invert()
        {
            // Inverts line by switching end point and start point. 
            Vector2 temp = startPoint;
            startPoint = endPoint;
            endPoint = startPoint;
        }

    }
}
