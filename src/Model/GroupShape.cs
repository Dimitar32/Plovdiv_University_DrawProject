using System;
using System.Collections.Generic;
using System.Drawing;

namespace Draw
{
    [Serializable]
    public class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) : base(rect)
        {
        }

        public GroupShape(Rectangle rectangle) : base(rectangle)
        {
        }

        public GroupShape(List<Shape> groupShapes) : base()
        {
            this.groupShapes = groupShapes;
        }
        #endregion

        #region Properties
        private List<Shape> groupShapes = new List<Shape>();
        public virtual List<Shape> GroupShapes
        {
            get { return groupShapes; }
            set { groupShapes = value; }
        }
        #endregion

        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {
                foreach (Shape shape in groupShapes)
                {
                    if (shape.Contains(point)) 
                        return true;
                }

                return true;
            }
                
            return false;
        }

        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach (Shape shape in groupShapes)
            {
                shape.DrawSelf(grfx);
            }
        }

        public override void ChangeFillColor(Color color)
        {
            foreach (Shape shape in groupShapes)
            {
                shape.ChangeFillColor(color);
            }
        }

        public override void ChangeBorderColor(Color color)
        {
            foreach (Shape shape in groupShapes)
            {
                shape.BorderColor = color;
            }
        }

        public override void ChangeBorderWidth(int borderWidth)
        {
            foreach (Shape shape in groupShapes)
            {
                shape.BorderWidth = borderWidth;
            }
        }

        public override void Resize(int width, int height)
        {
            foreach (Shape shape in groupShapes)
            {
                shape.Resize(width, height);
            }
        }

        public override void MoveGroupedShape(float dx, float dy)
        {
            base.MoveGroupedShape(dx, dy);
            foreach (Shape shape in groupShapes)
            {
                shape.MoveGroupedShape(dx * 2, dy * 2);
            }
        }
    }
}
