var root = new Node("O prato é uma massa?", false);

root.RightNode = new Node("Lasanha", true, root);

root.LeftNode = new Node("Bolo de chocolate", true, root);

var tree = new Tree(root);

Game.StartGame(tree);
