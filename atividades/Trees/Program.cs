using Trees;

tree<int> tree = new tree<int>();

tree.Root = new TreeNode<int>() {
    Data = 1000
};

    tree.Root.Data = 100;
    tree.Root.Children = new List<TreeNode<int>>
    {
        new TreeNode<int>()   {
            Data = 50,
            Parent = tree.Root
    },
new TreeNode<int>()   {
            Data = 5,
            Parent = tree.Root
    }
};
TreeNode<int> filho3 = new TreeNode<int>();
filho3.Data = 0;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);

tree.Root.Children[0].Children =
     new List<TreeNode<int>>
{
        new TreeNode<int>()   {
            Data = 50,
            Parent = tree.Root
  }
};
TreeNode<int> neto2 = new TreeNode<int>();
neto2.Data = 200;
neto2.Parent = tree.Root.Children[1];
    
tree.Root.Children[1].Children.Add(neto2);
int level = tree.Root.GetHeight();
string message = $"Esta árvore contém {level} nível";
Console.WriteLine(message);
