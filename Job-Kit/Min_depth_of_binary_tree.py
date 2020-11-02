class Node:
    def  __init__(self,key):
        self.data = key
        self.left = None
        self.right = None
        


def min_depth_bin_tree(root):
    if(root == None):
        return 0
    else:
        ldepth = min_depth_bin_tree(root.left)
        rdepth = min_depth_bin_tree(root.right)

        if(ldepth > rdepth):
            return 1+rdepth
        else:
            return 1+ldepth



root = Node(1)
root.left = Node(2)
root.right = Node(3)
root.left.left = Node(4)
root.left.right = Node(5)
root.left.left.right = Node(7)
root.right.right = Node(6)


print(min_depth_bin_tree(root))