using System;
using System.Collections.Generic;

// The component interface declares common operations for both
// simple and complex objects of a composition.
interface IGraphic
{
    void Move(int x, int y);
    void Draw();
}

// The leaf class represents end objects of a composition. A
// leaf object can't have any sub-objects. Usually, it's leaf
// objects that do the actual work, while composite objects only
// delegate to their sub-components.
class Dot : IGraphic
{
    private int x, y;

    public Dot(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(int x, int y)
    {
        this.x += x;
        this.y += y;
    }

    public void Draw()
    {
        // Draw a dot at X and Y.
    }
}

// All component classes can extend other components.
class Circle : Dot
{
    private int radius;

    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }

    public new void Draw()
    {
        // Draw a circle at X and Y with radius R.
    }
}

// The composite class represents complex components that may
// have children. Composite objects usually delegate the actual
// work to their children and then "sum up" the result.
class CompoundGraphic : IGraphic
{
    private List<IGraphic> children = new List<IGraphic>();

    public void Add(IGraphic child)
    {
        children.Add(child);
    }

    public void Remove(IGraphic child)
    {
        children.Remove(child);
    }

    public void Move(int x, int y)
    {
        foreach (var child in children)
        {
            child.Move(x, y);
        }
    }

    public void Draw()
    {
        foreach (var child in children)
        {
            child.Draw();
            // Update the bounding rectangle.
        }
        // Draw a dashed rectangle using the bounding coordinates.
    }
}

// The client code works with all the components via their base
// interface. This way the client code can support simple leaf
// components as well as complex composites.
class ImageEditor
{
    private CompoundGraphic all;

    public void Load()
    {
        all = new CompoundGraphic();
        all.Add(new Dot(1, 2));
        all.Add(new Circle(5, 3, 10));
        // ...
    }

    public void GroupSelected(IGraphic[] components)
    {
        CompoundGraphic group = new CompoundGraphic();
        foreach (var component in components)
        {
            group.Add(component);
            all.Remove(component);
        }
        all.Add(group);
        // All components will be drawn.
        all.Draw();
    }
}