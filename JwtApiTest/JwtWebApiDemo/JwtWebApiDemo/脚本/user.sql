/*
 Navicat Premium Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 50626
 Source Host           : localhost:3306
 Source Schema         : test

 Target Server Type    : MySQL
 Target Server Version : 50626
 File Encoding         : 65001

 Date: 08/01/2023 14:48:04
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user`  (
  `user_id` bigint(20) NOT NULL COMMENT '主键ID',
  `tenant_id` bigint(20) NOT NULL COMMENT '租户ID',
  `name` varchar(30) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '名称',
  `age` int(11) NULL DEFAULT NULL COMMENT '年龄',
  `test_type` int(11) NULL DEFAULT NULL COMMENT '测试下划线字段命名类型',
  `test_date` datetime NULL DEFAULT NULL COMMENT '日期',
  `role` bigint(20) NULL DEFAULT NULL COMMENT '测试',
  `phone` varchar(11) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '手机号码',
  `pwd` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL COMMENT '密码',
  PRIMARY KEY (`user_id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Compact;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES (0, 1, '雷锋', 1, 1, '2017-01-01 01:01:01', 1, '10010', '123456');
INSERT INTO `user` VALUES (1, 1, '三毛', 2, 1, '2017-02-02 01:01:01', 1, '10086', NULL);
INSERT INTO `user` VALUES (2, 1, '小马', 1, 1, '2017-03-03 01:01:01', 1, '10000', NULL);
INSERT INTO `user` VALUES (3, 2, '麻花藤', 1, 1, '2017-03-03 01:01:01', 1, '10000', NULL);
INSERT INTO `user` VALUES (4, 2, '东狗', 2, 1, '2017-03-03 01:01:01', 1, '10086', NULL);
INSERT INTO `user` VALUES (5, 1, '王五', 2, 1, '2017-03-03 01:01:01', 1, '10010', NULL);

SET FOREIGN_KEY_CHECKS = 1;
