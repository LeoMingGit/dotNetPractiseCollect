using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 树形实体
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parentId")]
        public string ParentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("label")]
        public string Name { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("level")]
        public int level { set; get; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("children")]
        public List<TreeNode> Children { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void AddChilrden(TreeNode node)
        {
            if (Children == null)
                Children = new List<TreeNode>();
            this.Children.Add(node);
        }
    }

    /// <summary>
    /// 树形结构帮助类
    /// </summary>
    public class TreeBuilder
    {

        /// <summary>
        /// 生成树形结构
        /// </summary>
        /// <param name="locations"></param>
        /// <param name="rootId"></param>
        /// <returns></returns>
        public static List<TreeNode> BuildTree(List<TreeNode> locations, string rootId = "0")
        {
            var rootLocations = locations.Where(l => l.ParentId == rootId).ToList();
            foreach (var location in rootLocations)
            {
                location.Children = BuildChildren(location.Id.ToString(), locations, 1);
            }
            return rootLocations;
        }

        /// <summary>
        /// 生成孩子节点
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="locations"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        private static List<TreeNode> BuildChildren(string parentId, List<TreeNode> locations, int level)
        {
            var children = locations.Where(l => l.ParentId == parentId).ToList();
            foreach (var child in children)
            {
                child.level = level;
                child.Children = BuildChildren(child.Id, locations, level + 1);
            }
            if (children.Count == 0) return null;
            return children;
        }


        /// <summary>
        /// 获取最末级节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static TreeNode GetLastNode(TreeNode node)
        {
            if (node.Children == null || node.Children.Count == 0)
            {
                return node;
            }
            else
            {
                return GetLastNode(node.Children.Last());
            }
        }

        /// <summary>
        /// 获取树形结构的所有节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static List<TreeNode> GetAllNodes(TreeNode node)
        {
            List<TreeNode> allNodes = new List<TreeNode>();
            allNodes.Add(node);
            if (node.Children != null)
            {
                foreach (TreeNode childNode in node.Children)
                {
                    allNodes.AddRange(GetAllNodes(childNode));
                }
            }
            return allNodes;
        }
    }


}
