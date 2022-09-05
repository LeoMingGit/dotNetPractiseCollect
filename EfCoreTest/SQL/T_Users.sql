/*
Navicat SQL Server Data Transfer

Source Server         : sqlserver
Source Server Version : 110000
Source Host           : Computer-2021TO\SQLEXPRESS:1433
Source Database       : YZK
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 110000
File Encoding         : 65001

Date: 2022-09-05 20:25:56
*/


-- ----------------------------
-- Table structure for T_Users
-- ----------------------------
DROP TABLE [dbo].[T_Users]
GO
CREATE TABLE [dbo].[T_Users] (
[ID] bigint NOT NULL ,
[JobTitle] varchar(500) NULL ,
[EmailAddress] varchar(500) NULL ,
[FirstNameLastName] varchar(500) NULL ,
[Newcolumn] varchar(500) NULL 
)


GO

-- ----------------------------
-- Records of T_Users
-- ----------------------------
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'1', N'Accountant', N'Manuel_James8953@tonsy.org', N'Manuel James', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'2', N'Project Manager', N'Caydence_Devonport2397@elnee.tech', N'Caydence Devonport', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'3', N'Food Technologist', N'William_Hall7028@infotech44.tech', N'William Hall', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'4', N'Assistant Buyer', N'Barry_Wooldridge1009@cispeto.com', N'Barry Wooldridge', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'5', N'Design Engineer', N'William_Durrant1676@hourpy.biz', N'William Durrant', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'6', N'Lecturer', N'Peyton_Thomas3776@sveldo.biz', N'Peyton Thomas', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'7', N'Electrician', N'Julian_Uddin2222@gembat.biz', N'Julian Uddin', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'8', N'Bookkeeper', N'Luke_Mccormick3874@deavo.com', N'Luke Mccormick', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'9', N'Call Center Representative', N'Georgia_Veale6779@twipet.com', N'Georgia Veale', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'10', N'Call Center Representative', N'Carl_Duvall5980@irrepsy.com', N'Carl Duvall', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'11', N'Treasurer', N'Boris_Curtis8513@twipet.com', N'Boris Curtis', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'12', N'Staffing Consultant', N'Ronald_Faulkner2932@extex.org', N'Ronald Faulkner', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'13', N'Biologist', N'Fred_Lucas1216@acrit.org', N'Fred Lucas', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'14', N'Mobile Developer', N'Mason_Mooney8227@acrit.org', N'Mason Mooney', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'15', N'Lecturer', N'Juliet_Parker7481@supunk.biz', N'Juliet Parker', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'16', N'Electrician', N'Hank_Butler4283@kideod.biz', N'Hank Butler', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'17', N'Electrician', N'Daniel_Ranks2890@elnee.tech', N'Daniel Ranks', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'18', N'Health Educator', N'Mark_Connell1183@deavo.com', N'Mark Connell', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'19', N'Dentist', N'Benjamin_Upton9410@deavo.com', N'Benjamin Upton', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'20', N'Restaurant Manager', N'Leroy_Amstead6163@joiniaa.com', N'Leroy Amstead', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'21', N'Cook', N'Maia_Knight9113@bretoux.com', N'Maia Knight', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'22', N'Global Logistics Supervisor', N'Nicholas_Buckley9200@grannar.com', N'Nicholas Buckley', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'23', N'Budget Analyst', N'Cherish_Jeffery6730@nimogy.biz', N'Cherish Jeffery', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'24', N'Budget Analyst', N'Rufus_Edwards7236@gompie.com', N'Rufus Edwards', N'Vanderbilt University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'25', N'Software Engineer', N'Alexander_Bristow93@grannar.com', N'Alexander Bristow', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'26', N'Project Manager', N'Mike_Eagle4075@muall.tech', N'Mike Eagle', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'27', N'Cashier', N'Aiden_Utterson1577@extex.org', N'Aiden Utterson', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'28', N'Business Broker', N'Celia_Widdows7138@guentu.biz', N'Celia Widdows', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'29', N'Global Logistics Supervisor', N'Rihanna_Mason7350@gompie.com', N'Rihanna Mason', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'30', N'Physician', N'Hayden_Tyrrell139@bungar.biz', N'Hayden Tyrrell', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'31', N'Front Desk Coordinator', N'Faith_Pope402@bretoux.com', N'Faith Pope', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'32', N'HR Specialist', N'Nick_Styles5679@cispeto.com', N'Nick Styles', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'33', N'Loan Officer', N'Jenna_Smith6524@bauros.biz', N'Jenna Smith', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'34', N'Clerk', N'Payton_Bristow948@famism.biz', N'Payton Bristow', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'35', N'Call Center Representative', N'Rita_Rainford684@kideod.biz', N'Rita Rainford', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'36', N'Staffing Consultant', N'Ron_Trent5863@dionrab.com', N'Ron Trent', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'37', N'Global Logistics Supervisor', N'Benjamin_Khan583@joiniaa.com', N'Benjamin Khan', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'38', N'Laboratory Technician', N'Rose_Wheeler1829@supunk.biz', N'Rose Wheeler', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'39', N'Health Educator', N'Harry_Emmett2529@yahoo.com', N'Harry Emmett', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'40', N'Front Desk Coordinator', N'Faith_Morris650@qater.org', N'Faith Morris', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'41', N'Pharmacist', N'Danielle_Rowlands6866@nanoff.biz', N'Danielle Rowlands', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'42', N'Ambulatory Nurse', N'Emely_Murray6477@deavo.com', N'Emely Murray', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'43', N'Staffing Consultant', N'Mike_Sheldon598@zorer.org', N'Mike Sheldon', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'44', N'Steward', N'Julian_Pratt325@ubusive.com', N'Julian Pratt', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'45', N'Web Developer', N'Mason_Nielson5487@deavo.com', N'Mason Nielson', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'46', N'Food Technologist', N'Mark_Gordon2062@vetan.org', N'Mark Gordon', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'47', N'Steward', N'Noah_Fisher3104@twace.org', N'Noah Fisher', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'48', N'Call Center Representative', N'Rick_Grant9829@qater.org', N'Rick Grant', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'49', N'HR Coordinator', N'Boris_Funnell8510@eirey.tech', N'Boris Funnell', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'50', N'Operator', N'Angelique_Steer11@nanoff.biz', N'Angelique Steer', N'University of California, Riverside')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'51', N'Staffing Consultant', N'Nathan_Egerton2582@fuliss.net', N'Nathan Egerton', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'52', N'Stockbroker', N'Jenna_Harris2004@irrepsy.com', N'Jenna Harris', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'53', N'Pharmacist', N'Thea_Styles8595@sheye.org', N'Thea Styles', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'54', N'Budget Analyst', N'Denis_Murray3757@corti.com', N'Denis Murray', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'55', N'Service Supervisor', N'Rufus_Ellis9571@kideod.biz', N'Rufus Ellis', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'56', N'Doctor', N'Kenzie_Eddison8508@jiman.org', N'Kenzie Eddison', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'57', N'HR Specialist', N'Jolene_Edley7719@bungar.biz', N'Jolene Edley', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'58', N'Pharmacist', N'Bob_Fall3928@bretoux.com', N'Bob Fall', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'59', N'Mobile Developer', N'Aiden_Eyres5107@jiman.org', N'Aiden Eyres', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'60', N'Doctor', N'Lillian_Little134@nanoff.biz', N'Lillian Little', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'61', N'Operator', N'Denis_Cooper5104@atink.com', N'Denis Cooper', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'62', N'Auditor', N'Carina_Hancock5626@nanoff.biz', N'Carina Hancock', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'63', N'CNC Operator', N'Abbey_Rosenbloom1472@infotech44.tech', N'Abbey Rosenbloom', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'64', N'Software Engineer', N'Felicity_White9909@liret.org', N'Felicity White', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'65', N'Cook', N'Lucas_Holmes7720@liret.org', N'Lucas Holmes', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'66', N'Executive Director', N'Rachael_Eyres1643@gmail.com', N'Rachael Eyres', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'67', N'Systems Administrator', N'Anabel_Miller1015@twipet.com', N'Anabel Miller', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'68', N'Associate Professor', N'Ron_Addis1992@nanoff.biz', N'Ron Addis', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'69', N'Food Technologist', N'Mason_Donnelly9219@bulaffy.com', N'Mason Donnelly', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'70', N'Cash Manager', N'Paula_Neville9392@cispeto.com', N'Paula Neville', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'71', N'Project Manager', N'Julius_Simpson5880@zorer.org', N'Julius Simpson', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'72', N'Budget Analyst', N'Jasmine_Hilton9388@infotech44.tech', N'Jasmine Hilton', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'73', N'Machine Operator', N'Vicky_Speed540@typill.biz', N'Vicky Speed', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'74', N'IT Support Staff', N'Tara_Rees4666@mafthy.com', N'Tara Rees', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'75', N'Audiologist', N'Cara_Silva7745@grannar.com', N'Cara Silva', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'76', N'Food Technologist', N'Josh_Hunter3136@sveldo.biz', N'Josh Hunter', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'77', N'Healthcare Specialist', N'Adina_Willis9294@eirey.tech', N'Adina Willis', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'78', N'Inspector', N'Barry_Sheldon7021@grannar.com', N'Barry Sheldon', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'79', N'Accountant', N'Mandy_Alldridge2758@naiker.biz', N'Mandy Alldridge', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'80', N'Associate Professor', N'Jenna_Yard4253@gompie.com', N'Jenna Yard', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'81', N'HR Specialist', N'Cassandra_Baldwin6964@deavo.com', N'Cassandra Baldwin', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'82', N'Machine Operator', N'Leroy_Randall3440@twace.org', N'Leroy Randall', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'83', N'Banker', N'John_Nicolas9960@supunk.biz', N'John Nicolas', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'84', N'Fabricator', N'Rowan_Quinnell3155@infotech44.tech', N'Rowan Quinnell', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'85', N'Auditor', N'Harvey_Flanders6794@famism.biz', N'Harvey Flanders', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'86', N'Investment  Advisor', N'Marvin_Grant8430@ubusive.com', N'Marvin Grant', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'87', N'Physician', N'Logan_Morris6629@elnee.tech', N'Logan Morris', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'88', N'IT Support Staff', N'Maddison_Mcleod1843@elnee.tech', N'Maddison Mcleod', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'89', N'Physician', N'Danny_Knott7503@ovock.tech', N'Danny Knott', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'90', N'Audiologist', N'Sabrina_Appleton807@deons.tech', N'Sabrina Appleton', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'91', N'Laboratory Technician', N'Gil_Hepburn508@eirey.tech', N'Gil Hepburn', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'92', N'Auditor', N'David_Davies5300@muall.tech', N'David Davies', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'93', N'Machine Operator', N'Leilani_Giles6237@naiker.biz', N'Leilani Giles', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'94', N'Audiologist', N'Benjamin_Drake3767@liret.org', N'Benjamin Drake', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'95', N'Budget Analyst', N'Brad_Price3377@sveldo.biz', N'Brad Price', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'96', N'Bellman', N'Katelyn_Owens1709@infotech44.tech', N'Katelyn Owens', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'97', N'Lecturer', N'Julian_Booth2970@supunk.biz', N'Julian Booth', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'98', N'Inspector', N'Abbey_Dillon3130@kideod.biz', N'Abbey Dillon', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'99', N'Audiologist', N'Gil_Trent187@ubusive.com', N'Gil Trent', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'100', N'Operator', N'Alba_Harrison5433@twace.org', N'Alba Harrison', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'101', N'Systems Administrator', N'Chadwick_Hopkinson8190@zorer.org', N'Chadwick Hopkinson', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'102', N'HR Coordinator', N'Liam_Rivers8379@gmail.com', N'Liam Rivers', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'103', N'Steward', N'Sage_Stevens6531@deavo.com', N'Sage Stevens', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'104', N'Retail Trainee', N'Russel_Bryson6248@mafthy.com', N'Russel Bryson', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'105', N'Software Engineer', N'Zoe_Dale2630@eirey.tech', N'Zoe Dale', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'106', N'Treasurer', N'Liv_Palmer5871@nimogy.biz', N'Liv Palmer', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'107', N'Web Developer', N'Harry_Crawford9610@twipet.com', N'Harry Crawford', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'108', N'Banker', N'Javier_Mould4250@cispeto.com', N'Javier Mould', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'109', N'Auditor', N'Daron_Gilbert2864@fuliss.net', N'Daron Gilbert', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'110', N'Operator', N'Aisha_Robinson1304@bretoux.com', N'Aisha Robinson', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'111', N'Laboratory Technician', N'Maya_Rowlands284@naiker.biz', N'Maya Rowlands', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'112', N'Service Supervisor', N'Chuck_Appleton2941@kideod.biz', N'Chuck Appleton', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'113', N'Service Supervisor', N'Violet_Coll7419@guentu.biz', N'Violet Coll', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'114', N'Assistant Buyer', N'Mark_Rothwell6780@bauros.biz', N'Mark Rothwell', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'115', N'Healthcare Specialist', N'Oliver_Abbot9754@ubusive.com', N'Oliver Abbot', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'116', N'Call Center Representative', N'Rocco_Wilton7173@dionrab.com', N'Rocco Wilton', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'117', N'Accountant', N'Maya_Nielson5525@dionrab.com', N'Maya Nielson', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'118', N'IT Support Staff', N'Boris_Villiger4222@qater.org', N'Boris Villiger', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'119', N'Doctor', N'Emerald_Jenkin317@brety.org', N'Emerald Jenkin', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'120', N'Front Desk Coordinator', N'Susan_Anderson1258@gompie.com', N'Susan Anderson', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'121', N'Project Manager', N'Chad_Stevens8140@yahoo.com', N'Chad Stevens', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'122', N'Bookkeeper', N'Dani_Ellery6826@naiker.biz', N'Dani Ellery', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'123', N'Paramedic', N'Chad_Hopkins4685@dionrab.com', N'Chad Hopkins', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'124', N'Pharmacist', N'Bart_Phillips3483@zorer.org', N'Bart Phillips', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'125', N'Executive Director', N'Ron_Bright5061@iatim.tech', N'Ron Bright', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'126', N'Cash Manager', N'Chadwick_Neal8364@cispeto.com', N'Chadwick Neal', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'127', N'IT Support Staff', N'Wade_Stone 9498@ubusive.com', N'Wade Stone ', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'128', N'Ambulatory Nurse', N'Emerald_Greenwood4999@corti.com', N'Emerald Greenwood', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'129', N'Ambulatory Nurse', N'Bryon_Edmonds1498@elnee.tech', N'Bryon Edmonds', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'130', N'Call Center Representative', N'Chanelle_Swift1458@mafthy.com', N'Chanelle Swift', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'131', N'Dentist', N'Adalie_Olivier5487@gmail.com', N'Adalie Olivier', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'132', N'Stockbroker', N'Bryon_Antcliff5479@muall.tech', N'Bryon Antcliff', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'133', N'Auditor', N'Abdul_Grant1516@ovock.tech', N'Abdul Grant', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'134', N'Bellman', N'Marvin_Cork901@iatim.tech', N'Marvin Cork', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'135', N'Cook', N'Ethan_Casey7235@joiniaa.com', N'Ethan Casey', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'136', N'Stockbroker', N'Lynn_Shea1223@zorer.org', N'Lynn Shea', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'137', N'HR Specialist', N'Valentina_Varley7761@ovock.tech', N'Valentina Varley', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'138', N'Loan Officer', N'Ethan_Roberts6572@ovock.tech', N'Ethan Roberts', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'139', N'Treasurer', N'Adalie_Zaoui7297@grannar.com', N'Adalie Zaoui', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'140', N'Restaurant Manager', N'Willow_Savage2436@grannar.com', N'Willow Savage', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'141', N'Global Logistics Supervisor', N'Tyler_Rust688@dionrab.com', N'Tyler Rust', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'142', N'Dentist', N'Roger_Hunt6861@iatim.tech', N'Roger Hunt', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'143', N'HR Specialist', N'Sienna_Rowlands4664@eirey.tech', N'Sienna Rowlands', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'144', N'Dentist', N'Melinda_Warner3198@mafthy.com', N'Melinda Warner', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'145', N'Physician', N'Courtney_Summers4051@sheye.org', N'Courtney Summers', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'146', N'Business Broker', N'Doug_Roman8759@acrit.org', N'Doug Roman', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'147', N'Service Supervisor', N'Marvin_Quinton9294@nimogy.biz', N'Marvin Quinton', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'148', N'Systems Administrator', N'Joseph_Evans2876@brety.org', N'Joseph Evans', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'149', N'Budget Analyst', N'Martin_Bowen4669@famism.biz', N'Martin Bowen', N'University of Texas at Austin')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'150', N'Cashier', N'Mike_Coates8532@kideod.biz', N'Mike Coates', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'151', N'Operator', N'Peter_Mason9095@liret.org', N'Peter Mason', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'152', N'Design Engineer', N'Sarah_Evans9129@gompie.com', N'Sarah Evans', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'153', N'Bellman', N'Joseph_Harrington353@gompie.com', N'Joseph Harrington', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'154', N'Accountant', N'Judith_Andrews2930@qater.org', N'Judith Andrews', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'155', N'Front Desk Coordinator', N'Lily_Pierce2269@twipet.com', N'Lily Pierce', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'156', N'Healthcare Specialist', N'Laila_Gray5087@naiker.biz', N'Laila Gray', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'157', N'Cash Manager', N'Freya_Hopkins4714@cispeto.com', N'Freya Hopkins', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'158', N'Bellman', N'Javier_Allwood8908@guentu.biz', N'Javier Allwood', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'159', N'Call Center Representative', N'Macy_Uttridge3805@nanoff.biz', N'Macy Uttridge', N'University of Texas Dallas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'160', N'Lecturer', N'Nicholas_Cork2932@joiniaa.com', N'Nicholas Cork', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'161', N'Clerk', N'Mandy_Walsh7847@dionrab.com', N'Mandy Walsh', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'162', N'Physician', N'Manuel_Calderwood3379@gembat.biz', N'Manuel Calderwood', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'163', N'Lecturer', N'Harmony_Russel3928@ovock.tech', N'Harmony Russel', N'University of California, Riverside')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'164', N'HR Specialist', N'Abdul_Herbert6199@naiker.biz', N'Abdul Herbert', N'Vanderbilt University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'165', N'Project Manager', N'Hayden_Lowe1080@nanoff.biz', N'Hayden Lowe', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'166', N'Chef Manager', N'Stacy_Barrett8194@extex.org', N'Stacy Barrett', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'167', N'Accountant', N'Drew_Vaughn9476@joiniaa.com', N'Drew Vaughn', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'168', N'Pharmacist', N'Denny_Rowan4599@ubusive.com', N'Denny Rowan', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'169', N'CNC Operator', N'Domenic_Yard2934@sveldo.biz', N'Domenic Yard', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'170', N'Food Technologist', N'Anabelle_Snow514@deavo.com', N'Anabelle Snow', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'171', N'CNC Operator', N'Peyton_Bryant9445@ovock.tech', N'Peyton Bryant', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'172', N'Inspector', N'Bernadette_Bristow3799@mafthy.com', N'Bernadette Bristow', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'173', N'Cook', N'John_Snell8363@kideod.biz', N'John Snell', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'174', N'HR Coordinator', N'Tom_Walsh8888@twace.org', N'Tom Walsh', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'175', N'Restaurant Manager', N'Norah_Warren6832@sheye.org', N'Norah Warren', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'176', N'Laboratory Technician', N'Johnny_Freeburn3804@vetan.org', N'Johnny Freeburn', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'177', N'Cashier', N'Melinda_Tutton5228@iatim.tech', N'Melinda Tutton', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'178', N'Front Desk Coordinator', N'Logan_Mullins2654@extex.org', N'Logan Mullins', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'179', N'Cash Manager', N'Robyn_Cox8081@sheye.org', N'Robyn Cox', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'180', N'Healthcare Specialist', N'Stephanie_Bayliss8190@bulaffy.com', N'Stephanie Bayliss', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'181', N'Inspector', N'Rachael_Dillon8396@fuliss.net', N'Rachael Dillon', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'182', N'Audiologist', N'Rick_Fields5138@jiman.org', N'Rick Fields', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'183', N'Doctor', N'Julius_Simmons7774@deons.tech', N'Julius Simmons', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'184', N'Healthcare Specialist', N'Julianna_Speed8468@grannar.com', N'Julianna Speed', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'185', N'Assistant Buyer', N'Jocelyn_Graham7222@grannar.com', N'Jocelyn Graham', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'186', N'Audiologist', N'Beatrice_Hammond9796@twipet.com', N'Beatrice Hammond', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'187', N'Audiologist', N'Cadence_Smith4927@irrepsy.com', N'Cadence Smith', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'188', N'Steward', N'John_Farmer8188@guentu.biz', N'John Farmer', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'189', N'Electrician', N'Hannah_Nielson4624@liret.org', N'Hannah Nielson', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'190', N'Ambulatory Nurse', N'Carla_Ellis7235@naiker.biz', N'Carla Ellis', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'191', N'Loan Officer', N'Kieth_Clark7875@womeona.net', N'Kieth Clark', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'192', N'Bookkeeper', N'John_Gilmore760@nanoff.biz', N'John Gilmore', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'193', N'Banker', N'Mason_Umney6646@cispeto.com', N'Mason Umney', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'194', N'Paramedic', N'Ivette_Addison588@ovock.tech', N'Ivette Addison', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'195', N'Bellman', N'Michelle_Whitmore6722@muall.tech', N'Michelle Whitmore', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'196', N'Cash Manager', N'Maia_Rodgers3615@gompie.com', N'Maia Rodgers', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'197', N'Production Painter', N'Martin_Brown677@grannar.com', N'Martin Brown', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'198', N'HR Specialist', N'Leslie_Wren2908@iatim.tech', N'Leslie Wren', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'199', N'Budget Analyst', N'Jayden_Parker5698@guentu.biz', N'Jayden Parker', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'200', N'Bookkeeper', N'Logan_York5125@brety.org', N'Logan York', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'201', N'Chef Manager', N'Maria_Swan9331@bulaffy.com', N'Maria Swan', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'202', N'Systems Administrator', N'Tony_Collins4098@extex.org', N'Tony Collins', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'203', N'Production Painter', N'Fred_Richards280@eirey.tech', N'Fred Richards', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'204', N'Inspector', N'Daron_Ellis6888@yahoo.com', N'Daron Ellis', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'205', N'Pharmacist', N'Priscilla_Nash8052@nickia.com', N'Priscilla Nash', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'206', N'HR Specialist', N'Joseph_Thornton7112@twace.org', N'Joseph Thornton', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'207', N'Fabricator', N'Boris_Redwood8873@liret.org', N'Boris Redwood', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'208', N'Paramedic', N'Gabriel_Woodcock4825@ubusive.com', N'Gabriel Woodcock', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'209', N'Clerk', N'Erica_Little8969@deavo.com', N'Erica Little', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'210', N'Fabricator', N'Jack_Fisher3362@sheye.org', N'Jack Fisher', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'211', N'Inspector', N'Lynn_Hope1219@acrit.org', N'Lynn Hope', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'212', N'Budget Analyst', N'Adina_Pond7954@kideod.biz', N'Adina Pond', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'213', N'Inspector', N'Alba_Jackson3366@guentu.biz', N'Alba Jackson', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'214', N'Associate Professor', N'Percy_Tyler4207@ubusive.com', N'Percy Tyler', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'215', N'Cashier', N'George_Cameron4498@jiman.org', N'George Cameron', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'216', N'Food Technologist', N'Javier_Jones9769@infotech44.tech', N'Javier Jones', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'217', N'Paramedic', N'Chad_Uttley2676@sheye.org', N'Chad Uttley', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'218', N'Front Desk Coordinator', N'Jayden_Robe8922@bretoux.com', N'Jayden Robe', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'219', N'Auditor', N'Rufus_Weldon76@bungar.biz', N'Rufus Weldon', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'220', N'Dentist', N'Leroy_Devonport1733@sveldo.biz', N'Leroy Devonport', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'221', N'Auditor', N'Doug_Jarvis9207@corti.com', N'Doug Jarvis', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'222', N'Electrician', N'Fred_Hepburn5724@irrepsy.com', N'Fred Hepburn', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'223', N'Healthcare Specialist', N'Scarlett_Radley9540@joiniaa.com', N'Scarlett Radley', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'224', N'Software Engineer', N'Phillip_Beal240@hourpy.biz', N'Phillip Beal', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'225', N'Web Developer', N'Joseph_Flack6579@bretoux.com', N'Joseph Flack', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'226', N'Accountant', N'Owen_Howard8307@deavo.com', N'Owen Howard', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'227', N'Systems Administrator', N'Michael_Carter4744@extex.org', N'Michael Carter', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'228', N'Executive Director', N'Mike_Ianson7004@famism.biz', N'Mike Ianson', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'229', N'Cashier', N'Jasmine_Warren6570@nimogy.biz', N'Jasmine Warren', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'230', N'Inspector', N'Moira_Tutton1606@mafthy.com', N'Moira Tutton', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'231', N'Auditor', N'Rae_Rodwell6972@zorer.org', N'Rae Rodwell', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'232', N'Business Broker', N'Jacqueline_Pearce8320@joiniaa.com', N'Jacqueline Pearce', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'233', N'CNC Operator', N'Isabella_Wilkinson2542@acrit.org', N'Isabella Wilkinson', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'234', N'Investment  Advisor', N'Leilani_Dickson132@naiker.biz', N'Leilani Dickson', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'235', N'Staffing Consultant', N'Joy_Hunt4074@qater.org', N'Joy Hunt', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'236', N'Retail Trainee', N'Barney_Owen1835@yahoo.com', N'Barney Owen', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'237', N'Service Supervisor', N'Erin_Savage2822@grannar.com', N'Erin Savage', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'238', N'Web Developer', N'Anthony_Cartwright2396@eirey.tech', N'Anthony Cartwright', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'239', N'Webmaster', N'Tom_Stewart807@deons.tech', N'Tom Stewart', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'240', N'HR Specialist', N'Alan_Hammond5632@atink.com', N'Alan Hammond', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'241', N'Bookkeeper', N'Anthony_Glass3223@zorer.org', N'Anthony Glass', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'242', N'Machine Operator', N'Sarah_Benfield2246@sheye.org', N'Sarah Benfield', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'243', N'Budget Analyst', N'Lucas_Khan6054@bulaffy.com', N'Lucas Khan', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'244', N'Fabricator', N'Jaylene_Corbett9433@bretoux.com', N'Jaylene Corbett', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'245', N'Business Broker', N'Lucas_Clifton4065@jiman.org', N'Lucas Clifton', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'246', N'HR Specialist', N'Alexander_Dallas3823@sveldo.biz', N'Alexander Dallas', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'247', N'Production Painter', N'Anthony_Yarwood3051@tonsy.org', N'Anthony Yarwood', N'University of New Mexico')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'248', N'Stockbroker', N'Harmony_Wilkinson2419@mafthy.com', N'Harmony Wilkinson', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'249', N'Call Center Representative', N'Maggie_Franks5473@eirey.tech', N'Maggie Franks', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'250', N'Banker', N'Colleen_Allwood5024@vetan.org', N'Colleen Allwood', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'251', N'Clerk', N'Leroy_Everett8004@qater.org', N'Leroy Everett', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'252', N'Front Desk Coordinator', N'Sebastian_Lee1180@eirey.tech', N'Sebastian Lee', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'253', N'Fabricator', N'Abdul_Yard6956@atink.com', N'Abdul Yard', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'254', N'Paramedic', N'Bob_Whatson8529@deavo.com', N'Bob Whatson', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'255', N'Banker', N'Andie_Graham5801@joiniaa.com', N'Andie Graham', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'256', N'HR Specialist', N'Jules_Long7223@nanoff.biz', N'Jules Long', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'257', N'Machine Operator', N'Matthew_Mcleod61@nanoff.biz', N'Matthew Mcleod', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'258', N'Investment  Advisor', N'Phillip_Salt4703@twace.org', N'Phillip Salt', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'259', N'Assistant Buyer', N'Nathan_Miller1442@brety.org', N'Nathan Miller', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'260', N'Retail Trainee', N'Alexander_Andersson8358@cispeto.com', N'Alexander Andersson', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'261', N'Bellman', N'Sara_Asher9811@nimogy.biz', N'Sara Asher', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'262', N'Systems Administrator', N'Lucas_Broomfield5535@hourpy.biz', N'Lucas Broomfield', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'263', N'Ambulatory Nurse', N'Rosalee_Huggins2860@nimogy.biz', N'Rosalee Huggins', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'264', N'Design Engineer', N'Shannon_Norton4308@tonsy.org', N'Shannon Norton', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'265', N'Auditor', N'Vicky_Varndell6585@bretoux.com', N'Vicky Varndell', N'University of Texas Dallas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'266', N'Loan Officer', N'Alexander_Vaughan4461@deons.tech', N'Alexander Vaughan', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'267', N'CNC Operator', N'Savannah_Mason8995@famism.biz', N'Savannah Mason', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'268', N'Operator', N'Tyson_Pearce8061@irrepsy.com', N'Tyson Pearce', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'269', N'Doctor', N'Domenic_Pearce4889@eirey.tech', N'Domenic Pearce', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'270', N'Webmaster', N'Carol_Douglas5332@nanoff.biz', N'Carol Douglas', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'271', N'Restaurant Manager', N'Chloe_Thomson6013@extex.org', N'Chloe Thomson', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'272', N'Ambulatory Nurse', N'Ramon_Leigh1485@sveldo.biz', N'Ramon Leigh', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'273', N'IT Support Staff', N'Benjamin_Tanner8299@hourpy.biz', N'Benjamin Tanner', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'274', N'Audiologist', N'Eduardo_Wilkinson8400@bungar.biz', N'Eduardo Wilkinson', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'275', N'Chef Manager', N'Johnathan_Fields8671@jiman.org', N'Johnathan Fields', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'276', N'Treasurer', N'Hanna_Goldsmith4787@irrepsy.com', N'Hanna Goldsmith', N'University of New Mexico')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'277', N'Health Educator', N'Payton_Tobin1452@ovock.tech', N'Payton Tobin', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'278', N'Pharmacist', N'Angelique_Graham3533@bungar.biz', N'Angelique Graham', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'279', N'Electrician', N'Josh_Gunn734@acrit.org', N'Josh Gunn', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'280', N'Cash Manager', N'Javier_Blackburn8406@bretoux.com', N'Javier Blackburn', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'281', N'Auditor', N'Selena_Janes3631@liret.org', N'Selena Janes', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'282', N'Loan Officer', N'Tiffany_Powell9756@tonsy.org', N'Tiffany Powell', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'283', N'Software Engineer', N'Mason_Lomax3465@vetan.org', N'Mason Lomax', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'284', N'Stockbroker', N'Chad_Robinson1032@elnee.tech', N'Chad Robinson', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'285', N'Service Supervisor', N'Moira_Dyson6282@elnee.tech', N'Moira Dyson', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'286', N'Ambulatory Nurse', N'Denny_Windsor6948@guentu.biz', N'Denny Windsor', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'287', N'Investment  Advisor', N'Gil_Lewis1658@irrepsy.com', N'Gil Lewis', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'288', N'Webmaster', N'Shelby_Giles7024@elnee.tech', N'Shelby Giles', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'289', N'Retail Trainee', N'Tom_Brennan8051@extex.org', N'Tom Brennan', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'290', N'Budget Analyst', N'Domenic_Watt7539@yahoo.com', N'Domenic Watt', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'291', N'Cashier', N'Marjorie_Edley7264@eirey.tech', N'Marjorie Edley', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'292', N'Baker', N'Daron_Strong9458@jiman.org', N'Daron Strong', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'293', N'Cash Manager', N'Sienna_Uddin42@zorer.org', N'Sienna Uddin', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'294', N'Health Educator', N'Sofia_Mould8916@sheye.org', N'Sofia Mould', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'295', N'Electrician', N'Joseph_Fulton4513@supunk.biz', N'Joseph Fulton', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'296', N'Associate Professor', N'Felicity_Williams1761@nanoff.biz', N'Felicity Williams', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'297', N'Call Center Representative', N'Johnny_Norris7325@elnee.tech', N'Johnny Norris', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'298', N'Clerk', N'Tyson_Bingham1616@atink.com', N'Tyson Bingham', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'299', N'Systems Administrator', N'Abdul_Whatson4803@nickia.com', N'Abdul Whatson', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'300', N'Budget Analyst', N'Caleb_Giles8845@deons.tech', N'Caleb Giles', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'301', N'CNC Operator', N'Tom_Sloan6949@grannar.com', N'Tom Sloan', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'302', N'Health Educator', N'William_Redwood3413@extex.org', N'William Redwood', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'303', N'Accountant', N'Carla_Squire2216@bretoux.com', N'Carla Squire', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'304', N'Dentist', N'Elena_Harrison5029@nickia.com', N'Elena Harrison', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'305', N'Systems Administrator', N'Chadwick_Harvey3411@grannar.com', N'Chadwick Harvey', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'306', N'Physician', N'Candice_Stuart6180@deavo.com', N'Candice Stuart', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'307', N'Machine Operator', N'Ron_Tailor6790@joiniaa.com', N'Ron Tailor', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'308', N'Service Supervisor', N'Elijah_Wilde7825@zorer.org', N'Elijah Wilde', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'309', N'Treasurer', N'Tony_Harrison8714@eirey.tech', N'Tony Harrison', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'310', N'Software Engineer', N'Janice_Walsh4370@liret.org', N'Janice Walsh', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'311', N'Global Logistics Supervisor', N'Alex_Hancock6120@atink.com', N'Alex Hancock', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'312', N'IT Support Staff', N'George_Harper2592@cispeto.com', N'George Harper', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'313', N'Restaurant Manager', N'Alexia_Pearson6713@iatim.tech', N'Alexia Pearson', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'314', N'Systems Administrator', N'John_Davies4617@kideod.biz', N'John Davies', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'315', N'Front Desk Coordinator', N'Tony_Rees1851@twace.org', N'Tony Rees', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'316', N'Baker', N'Tyler_Varndell7295@womeona.net', N'Tyler Varndell', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'317', N'Clerk', N'Chadwick_Hunter7213@hourpy.biz', N'Chadwick Hunter', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'318', N'Laboratory Technician', N'Chad_Matthews6049@bauros.biz', N'Chad Matthews', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'319', N'Mobile Developer', N'Marigold_Murphy6977@twipet.com', N'Marigold Murphy', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'320', N'Chef Manager', N'Logan_Lloyd3956@irrepsy.com', N'Logan Lloyd', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'321', N'Laboratory Technician', N'Tania_Dobson873@tonsy.org', N'Tania Dobson', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'322', N'Auditor', N'Charlize_Baldwin6147@deons.tech', N'Charlize Baldwin', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'323', N'Executive Director', N'Camellia_Bailey3656@nanoff.biz', N'Camellia Bailey', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'324', N'Retail Trainee', N'Agnes_London2427@eirey.tech', N'Agnes London', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'325', N'Systems Administrator', N'Kaylee_Curtis3566@zorer.org', N'Kaylee Curtis', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'326', N'Pharmacist', N'Rocco_Sinclair5694@zorer.org', N'Rocco Sinclair', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'327', N'Machine Operator', N'Luke_Gregory1926@brety.org', N'Luke Gregory', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'328', N'Business Broker', N'Aiden_Rust2990@iatim.tech', N'Aiden Rust', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'329', N'Baker', N'Daniel_Lambert9340@dionrab.com', N'Daniel Lambert', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'330', N'Lecturer', N'Luke_Page 2304@hourpy.biz', N'Luke Page ', N'Vanderbilt University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'331', N'Software Engineer', N'Gil_Wise3071@elnee.tech', N'Gil Wise', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'332', N'Production Painter', N'Greta_Hamilton5292@supunk.biz', N'Greta Hamilton', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'333', N'Project Manager', N'Mark_Lindsay2293@naiker.biz', N'Mark Lindsay', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'334', N'Auditor', N'Ron_Chapman7952@nimogy.biz', N'Ron Chapman', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'335', N'Food Technologist', N'Rocco_Roth8931@iatim.tech', N'Rocco Roth', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'336', N'Chef Manager', N'Sonya_Collins2022@bauros.biz', N'Sonya Collins', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'337', N'Inspector', N'Drew_Robinson6966@vetan.org', N'Drew Robinson', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'338', N'Laboratory Technician', N'Valerie_Walsh482@nanoff.biz', N'Valerie Walsh', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'339', N'Ambulatory Nurse', N'Marilyn_Nelson7546@nickia.com', N'Marilyn Nelson', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'340', N'Laboratory Technician', N'Gloria_Collins7574@acrit.org', N'Gloria Collins', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'341', N'Pharmacist', N'Ally_Hastings294@iatim.tech', N'Ally Hastings', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'342', N'Paramedic', N'Peyton_Steer620@deons.tech', N'Peyton Steer', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'343', N'Biologist', N'Cassandra_Thatcher4618@sveldo.biz', N'Cassandra Thatcher', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'344', N'Dentist', N'Chris_Weatcroft846@deons.tech', N'Chris Weatcroft', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'345', N'Assistant Buyer', N'Mavis_Sawyer2590@gembat.biz', N'Mavis Sawyer', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'346', N'Fabricator', N'Grace_Taylor5279@yahoo.com', N'Grace Taylor', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'347', N'Loan Officer', N'Lillian_Knight5860@sheye.org', N'Lillian Knight', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'348', N'Laboratory Technician', N'Hailey_Smith2403@cispeto.com', N'Hailey Smith', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'349', N'Lecturer', N'Ryan_Emmett5429@naiker.biz', N'Ryan Emmett', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'350', N'IT Support Staff', N'Marilyn_Graham8731@iatim.tech', N'Marilyn Graham', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'351', N'Food Technologist', N'Rocco_Archer900@bungar.biz', N'Rocco Archer', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'352', N'Dentist', N'Joseph_Ingham3121@joiniaa.com', N'Joseph Ingham', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'353', N'CNC Operator', N'Catherine_Taylor6942@gmail.com', N'Catherine Taylor', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'354', N'Ambulatory Nurse', N'Henry_Saunders2449@nickia.com', N'Henry Saunders', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'355', N'Investment  Advisor', N'Josh_Vernon1435@bulaffy.com', N'Josh Vernon', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'356', N'Inspector', N'Summer_Murphy5889@yahoo.com', N'Summer Murphy', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'357', N'Stockbroker', N'Hope_Kelly3794@sheye.org', N'Hope Kelly', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'358', N'Webmaster', N'Mike_Shaw2648@bauros.biz', N'Mike Shaw', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'359', N'Insurance Broker', N'Greta_Thatcher2557@tonsy.org', N'Greta Thatcher', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'360', N'Service Supervisor', N'Samara_Eastwood4866@ubusive.com', N'Samara Eastwood', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'361', N'Healthcare Specialist', N'Candace_Barrett3328@liret.org', N'Candace Barrett', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'362', N'Biologist', N'Joseph_Radcliffe8927@bauros.biz', N'Joseph Radcliffe', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'363', N'Business Broker', N'Jacqueline_Faulkner1680@dionrab.com', N'Jacqueline Faulkner', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'364', N'Health Educator', N'Emery_Pratt8426@nanoff.biz', N'Emery Pratt', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'365', N'Software Engineer', N'Gina_Hood4512@atink.com', N'Gina Hood', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'366', N'Auditor', N'Leilani_Morris5275@bulaffy.com', N'Leilani Morris', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'367', N'Web Developer', N'Chuck_Avery4491@nimogy.biz', N'Chuck Avery', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'368', N'Investment  Advisor', N'Stacy_Anderson2568@guentu.biz', N'Stacy Anderson', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'369', N'Budget Analyst', N'Enoch_Roberts515@ubusive.com', N'Enoch Roberts', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'370', N'Executive Director', N'Chuck_Wills5932@cispeto.com', N'Chuck Wills', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'371', N'IT Support Staff', N'Tom_Lakey1606@womeona.net', N'Tom Lakey', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'372', N'Accountant', N'Eileen_James4826@iatim.tech', N'Eileen James', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'373', N'Bookkeeper', N'Ryan_Gilbert2581@nickia.com', N'Ryan Gilbert', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'374', N'Cashier', N'Isabel_Connell5846@joiniaa.com', N'Isabel Connell', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'375', N'HR Specialist', N'Carter_Yarwood1751@gompie.com', N'Carter Yarwood', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'376', N'Design Engineer', N'Angel_Forth3711@deavo.com', N'Angel Forth', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'377', N'Treasurer', N'Charlotte_Andrews6949@joiniaa.com', N'Charlotte Andrews', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'378', N'Ambulatory Nurse', N'Sebastian_Russel8430@twace.org', N'Sebastian Russel', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'379', N'Webmaster', N'Daphne_Saunders1091@bungar.biz', N'Daphne Saunders', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'380', N'Project Manager', N'Kaylee_Thorpe579@iatim.tech', N'Kaylee Thorpe', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'381', N'HR Coordinator', N'Barney_Needham9587@deavo.com', N'Barney Needham', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'382', N'Design Engineer', N'Piper_Hilton48@vetan.org', N'Piper Hilton', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'383', N'Electrician', N'Caleb_Henderson4340@brety.org', N'Caleb Henderson', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'384', N'Webmaster', N'Joy_Porter7819@bungar.biz', N'Joy Porter', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'385', N'Budget Analyst', N'Jessica_Collins7778@bungar.biz', N'Jessica Collins', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'386', N'Fabricator', N'Chad_Doherty4235@brety.org', N'Chad Doherty', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'387', N'Investment  Advisor', N'Isla_Gilmour3293@twace.org', N'Isla Gilmour', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'388', N'Bellman', N'Ellen_Parker8988@extex.org', N'Ellen Parker', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'389', N'Clerk', N'Benjamin_Swift7791@tonsy.org', N'Benjamin Swift', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'390', N'Call Center Representative', N'Leroy_Brooks6619@deons.tech', N'Leroy Brooks', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'391', N'Dentist', N'Chad_Jacobs104@infotech44.tech', N'Chad Jacobs', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'392', N'Operator', N'Cara_Hopkinson8021@gembat.biz', N'Cara Hopkinson', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'393', N'Cash Manager', N'Matt_Faulkner9520@bulaffy.com', N'Matt Faulkner', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'394', N'Stockbroker', N'Hanna_Wright5255@bulaffy.com', N'Hanna Wright', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'395', N'Audiologist', N'Bree_Paterson419@vetan.org', N'Bree Paterson', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'396', N'Cook', N'Rick_Hilton141@bulaffy.com', N'Rick Hilton', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'397', N'Physician', N'Julian_Cassidy9875@gmail.com', N'Julian Cassidy', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'398', N'Associate Professor', N'Nate_Hunter1905@extex.org', N'Nate Hunter', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'399', N'Global Logistics Supervisor', N'Chadwick_Woodcock607@bretoux.com', N'Chadwick Woodcock', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'400', N'Healthcare Specialist', N'Mike_Riley6041@womeona.net', N'Mike Riley', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'401', N'Health Educator', N'Wendy_Strong9888@extex.org', N'Wendy Strong', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'402', N'Food Technologist', N'Carmella_Andersson5413@twace.org', N'Carmella Andersson', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'403', N'Cook', N'Nancy_Hobson6194@guentu.biz', N'Nancy Hobson', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'404', N'Associate Professor', N'Lucas_Brock6068@irrepsy.com', N'Lucas Brock', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'405', N'Banker', N'Barry_Penn8437@muall.tech', N'Barry Penn', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'406', N'Front Desk Coordinator', N'Amy_Bennett9891@twace.org', N'Amy Bennett', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'407', N'Executive Director', N'Adalie_Donnelly1755@supunk.biz', N'Adalie Donnelly', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'408', N'Stockbroker', N'Marina_Saunders6301@bulaffy.com', N'Marina Saunders', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'409', N'Lecturer', N'Aleksandra_Richards5164@corti.com', N'Aleksandra Richards', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'410', N'IT Support Staff', N'Chester_Bayliss4827@muall.tech', N'Chester Bayliss', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'411', N'Web Developer', N'Ilona_Jeffery7696@typill.biz', N'Ilona Jeffery', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'412', N'IT Support Staff', N'Jack_Kaur838@twace.org', N'Jack Kaur', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'413', N'Cashier', N'Alma_Jennson7451@iatim.tech', N'Alma Jennson', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'414', N'Systems Administrator', N'Elly_Gaynor6433@brety.org', N'Elly Gaynor', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'415', N'Systems Administrator', N'Rocco_Knight7479@qater.org', N'Rocco Knight', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'416', N'Investment  Advisor', N'Denny_Carson984@bungar.biz', N'Denny Carson', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'417', N'Budget Analyst', N'Anthony_Hobbs3447@brety.org', N'Anthony Hobbs', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'418', N'Insurance Broker', N'Chris_Selby140@nickia.com', N'Chris Selby', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'419', N'Stockbroker', N'Cara_Campbell802@bretoux.com', N'Cara Campbell', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'420', N'Production Painter', N'Boris_Russel2895@qater.org', N'Boris Russel', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'421', N'Project Manager', N'Denny_Turner6956@deons.tech', N'Denny Turner', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'422', N'Paramedic', N'Rosalie_Wigley9901@sheye.org', N'Rosalie Wigley', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'423', N'Design Engineer', N'Carolyn_Upsdell1791@nanoff.biz', N'Carolyn Upsdell', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'424', N'Web Developer', N'Boris_Moore6178@bretoux.com', N'Boris Moore', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'425', N'Retail Trainee', N'Charlotte_Cox8744@irrepsy.com', N'Charlotte Cox', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'426', N'Laboratory Technician', N'Dasha_Anderson5889@bauros.biz', N'Dasha Anderson', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'427', N'Laboratory Technician', N'Rocco_Bloom5429@tonsy.org', N'Rocco Bloom', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'428', N'Systems Administrator', N'Cameron_Huggins6814@liret.org', N'Cameron Huggins', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'429', N'Biologist', N'Benjamin_Allington7762@nanoff.biz', N'Benjamin Allington', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'430', N'Banker', N'Maia_Dwyer3106@fuliss.net', N'Maia Dwyer', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'431', N'Service Supervisor', N'Luke_Mason4169@deons.tech', N'Luke Mason', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'432', N'Auditor', N'Brooklyn_Webster1105@hourpy.biz', N'Brooklyn Webster', N'University of Texas Dallas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'433', N'Staffing Consultant', N'Tom_Harrison2423@irrepsy.com', N'Tom Harrison', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'434', N'IT Support Staff', N'Lexi_Shaw5835@zorer.org', N'Lexi Shaw', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'435', N'Lecturer', N'Grace_Tennant1827@bretoux.com', N'Grace Tennant', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'436', N'Web Developer', N'Joy_Wilson1423@atink.com', N'Joy Wilson', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'437', N'Assistant Buyer', N'Liv_Aldridge3390@iatim.tech', N'Liv Aldridge', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'438', N'Cash Manager', N'Carter_Michael5380@irrepsy.com', N'Carter Michael', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'439', N'Designer', N'Enoch_Waterhouse2182@nanoff.biz', N'Enoch Waterhouse', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'440', N'Inspector', N'Denis_Brooks5350@mafthy.com', N'Denis Brooks', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'441', N'Chef Manager', N'Carter_Campbell3203@deons.tech', N'Carter Campbell', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'442', N'Associate Professor', N'Marvin_Collis2289@dionrab.com', N'Marvin Collis', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'443', N'Pharmacist', N'Javier_Wright8409@gmail.com', N'Javier Wright', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'444', N'Global Logistics Supervisor', N'Mona_Dixon9912@zorer.org', N'Mona Dixon', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'445', N'Restaurant Manager', N'Boris_Casey382@deavo.com', N'Boris Casey', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'446', N'Food Technologist', N'Maggie_Durrant3645@guentu.biz', N'Maggie Durrant', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'447', N'Biologist', N'Maribel_Grady853@nanoff.biz', N'Maribel Grady', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'448', N'Electrician', N'Jayden_Powell2257@extex.org', N'Jayden Powell', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'449', N'Staffing Consultant', N'Ethan_Hill2344@joiniaa.com', N'Ethan Hill', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'450', N'Health Educator', N'Isabel_Hall3581@mafthy.com', N'Isabel Hall', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'451', N'Web Developer', N'Hazel_Connell4731@zorer.org', N'Hazel Connell', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'452', N'Operator', N'Helen_Cartwright6834@acrit.org', N'Helen Cartwright', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'453', N'IT Support Staff', N'David_Shaw7256@qater.org', N'David Shaw', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'454', N'Systems Administrator', N'Jackeline_Lyon4897@iatim.tech', N'Jackeline Lyon', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'455', N'Fabricator', N'Kurt_Garcia5907@iatim.tech', N'Kurt Garcia', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'456', N'Service Supervisor', N'Barry_Yates1171@liret.org', N'Barry Yates', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'457', N'Associate Professor', N'Faith_Cameron547@nanoff.biz', N'Faith Cameron', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'458', N'Accountant', N'Mina_Olivier7478@gembat.biz', N'Mina Olivier', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'459', N'Mobile Developer', N'Nate_Willis2501@gembat.biz', N'Nate Willis', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'460', N'Fabricator', N'Natalie_Drake7276@extex.org', N'Natalie Drake', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'461', N'HR Coordinator', N'Moira_Cadman6147@iatim.tech', N'Moira Cadman', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'462', N'IT Support Staff', N'Madelyn_Carter4546@jiman.org', N'Madelyn Carter', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'463', N'Chef Manager', N'Charlotte_Dempsey4065@twipet.com', N'Charlotte Dempsey', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'464', N'Paramedic', N'Mavis_Addis122@nickia.com', N'Mavis Addis', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'465', N'Associate Professor', N'Russel_Edwards1728@mafthy.com', N'Russel Edwards', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'466', N'Accountant', N'Lynn_Owens5965@deavo.com', N'Lynn Owens', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'467', N'Bookkeeper', N'Angelica_Wise9489@iatim.tech', N'Angelica Wise', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'468', N'Steward', N'Mackenzie_Phillips7122@bulaffy.com', N'Mackenzie Phillips', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'469', N'Cash Manager', N'Matthew_Varley9435@guentu.biz', N'Matthew Varley', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'470', N'Laboratory Technician', N'David_Blackburn6671@bulaffy.com', N'David Blackburn', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'471', N'Dentist', N'Danny_Kidd5693@liret.org', N'Danny Kidd', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'472', N'Doctor', N'Henry_Hewitt553@deons.tech', N'Henry Hewitt', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'473', N'Retail Trainee', N'Marie_Thompson6771@dionrab.com', N'Marie Thompson', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'474', N'Healthcare Specialist', N'Bob_Davies8339@joiniaa.com', N'Bob Davies', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'475', N'Audiologist', N'Clint_Blackburn7127@corti.com', N'Clint Blackburn', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'476', N'Mobile Developer', N'Erica_Johnson6928@yahoo.com', N'Erica Johnson', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'477', N'Electrician', N'Bob_Hilton7992@famism.biz', N'Bob Hilton', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'478', N'Business Broker', N'Elly_Windsor8344@infotech44.tech', N'Elly Windsor', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'479', N'Designer', N'Chester_Thorne8210@supunk.biz', N'Chester Thorne', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'480', N'Budget Analyst', N'Mike_Vince5856@sheye.org', N'Mike Vince', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'481', N'Staffing Consultant', N'Nicholas_Saunders428@corti.com', N'Nicholas Saunders', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'482', N'Food Technologist', N'Emerald_Yarlett3483@naiker.biz', N'Emerald Yarlett', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'483', N'Executive Director', N'Stacy_Faulkner5356@womeona.net', N'Stacy Faulkner', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'484', N'Front Desk Coordinator', N'Lucas_Jones6372@kideod.biz', N'Lucas Jones', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'485', N'Insurance Broker', N'Angelica_Jennson2823@bulaffy.com', N'Angelica Jennson', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'486', N'Webmaster', N'Ronald_Ellis4621@sveldo.biz', N'Ronald Ellis', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'487', N'Ambulatory Nurse', N'Danny_Gaynor6081@brety.org', N'Danny Gaynor', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'488', N'Staffing Consultant', N'Nick_Hamilton2362@bungar.biz', N'Nick Hamilton', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'489', N'Auditor', N'Percy_Robinson405@nickia.com', N'Percy Robinson', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'490', N'Doctor', N'Elly_Rowlands8724@corti.com', N'Elly Rowlands', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'491', N'Cash Manager', N'Roger_Nicolas4219@famism.biz', N'Roger Nicolas', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'492', N'Assistant Buyer', N'Domenic_Rust7352@qater.org', N'Domenic Rust', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'493', N'Dentist', N'Javier_Brett9931@bungar.biz', N'Javier Brett', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'494', N'HR Coordinator', N'Lara_Lynn4488@nickia.com', N'Lara Lynn', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'495', N'Paramedic', N'Phoebe_Thorne2347@deavo.com', N'Phoebe Thorne', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'496', N'Baker', N'Chuck_Tyler8741@twace.org', N'Chuck Tyler', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'497', N'Assistant Buyer', N'Jacob_Mills8216@eirey.tech', N'Jacob Mills', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'498', N'Software Engineer', N'Agnes_Lane5527@jiman.org', N'Agnes Lane', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'499', N'Assistant Buyer', N'Ilona_Asher3715@gembat.biz', N'Ilona Asher', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'500', N'Food Technologist', N'Mark_Morris1339@gompie.com', N'Mark Morris', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'501', N'Web Developer', N'Alan_Carter8013@twipet.com', N'Alan Carter', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'502', N'HR Specialist', N'Livia_Welsch4224@extex.org', N'Livia Welsch', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'503', N'Ambulatory Nurse', N'Manuel_Button4504@deons.tech', N'Manuel Button', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'504', N'Accountant', N'Felicity_Robertson9188@supunk.biz', N'Felicity Robertson', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'505', N'Dentist', N'Erick_Stevens6854@guentu.biz', N'Erick Stevens', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'506', N'Systems Administrator', N'Beatrice_Osman9726@gembat.biz', N'Beatrice Osman', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'507', N'Mobile Developer', N'Erin_Jarrett2239@bauros.biz', N'Erin Jarrett', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'508', N'Audiologist', N'Harvey_Stewart4851@eirey.tech', N'Harvey Stewart', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'509', N'Ambulatory Nurse', N'Rick_Eyres8995@fuliss.net', N'Rick Eyres', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'510', N'Cashier', N'Eduardo_Collingwood945@vetan.org', N'Eduardo Collingwood', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'511', N'Steward', N'Jolene_Griffiths8795@mafthy.com', N'Jolene Griffiths', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'512', N'Staffing Consultant', N'George_Powell6387@sheye.org', N'George Powell', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'513', N'Food Technologist', N'Ronald_Patel6429@joiniaa.com', N'Ronald Patel', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'514', N'Fabricator', N'Candace_Nicolas1891@bauros.biz', N'Candace Nicolas', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'515', N'Health Educator', N'Barry_Robertson1468@qater.org', N'Barry Robertson', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'516', N'HR Coordinator', N'Elijah_Fisher6569@yahoo.com', N'Elijah Fisher', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'517', N'Pharmacist', N'Laila_Newton2433@acrit.org', N'Laila Newton', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'518', N'Banker', N'Bob_Darcy1982@atink.com', N'Bob Darcy', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'519', N'Pharmacist', N'Taylor_Walter8437@liret.org', N'Taylor Walter', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'520', N'Design Engineer', N'Benny_Knight9186@sveldo.biz', N'Benny Knight', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'521', N'Systems Administrator', N'Willow_Parker3671@womeona.net', N'Willow Parker', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'522', N'Electrician', N'Harvey_Emmett4115@corti.com', N'Harvey Emmett', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'523', N'Electrician', N'Angel_Miller7079@typill.biz', N'Angel Miller', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'524', N'Treasurer', N'Daniel_Shaw8147@cispeto.com', N'Daniel Shaw', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'525', N'Biologist', N'Abdul_Curtis2332@infotech44.tech', N'Abdul Curtis', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'526', N'Banker', N'Juliette_Abbot6099@nimogy.biz', N'Juliette Abbot', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'527', N'Lecturer', N'Matthew_Kaur7424@nickia.com', N'Matthew Kaur', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'528', N'HR Coordinator', N'Michael_Moss3042@bulaffy.com', N'Michael Moss', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'529', N'Electrician', N'Gwen_James277@nimogy.biz', N'Gwen James', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'530', N'Project Manager', N'Chloe_Lowe5048@nickia.com', N'Chloe Lowe', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'531', N'Retail Trainee', N'Carissa_Lewis1066@cispeto.com', N'Carissa Lewis', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'532', N'Designer', N'Nathan_Duvall8381@tonsy.org', N'Nathan Duvall', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'533', N'Doctor', N'Cecilia_Brooks619@ovock.tech', N'Cecilia Brooks', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'534', N'Cash Manager', N'John_Price29@cispeto.com', N'John Price', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'535', N'Laboratory Technician', N'Leroy_Taylor9998@twipet.com', N'Leroy Taylor', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'536', N'Chef Manager', N'Cecilia_Martin3958@hourpy.biz', N'Cecilia Martin', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'537', N'Systems Administrator', N'Chris_Cunningham5061@bretoux.com', N'Chris Cunningham', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'538', N'Webmaster', N'Mackenzie_Clarkson7109@tonsy.org', N'Mackenzie Clarkson', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'539', N'Operator', N'Cassidy_Corbett91@twace.org', N'Cassidy Corbett', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'540', N'Laboratory Technician', N'Alexander_Coll9088@twace.org', N'Alexander Coll', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'541', N'HR Specialist', N'Sofia_Aldridge1338@acrit.org', N'Sofia Aldridge', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'542', N'Systems Administrator', N'Domenic_Gordon2056@extex.org', N'Domenic Gordon', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'543', N'HR Specialist', N'Drew_Stevenson830@kideod.biz', N'Drew Stevenson', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'544', N'Lecturer', N'Barney_Brown6975@twace.org', N'Barney Brown', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'545', N'Call Center Representative', N'Denny_Evans1805@jiman.org', N'Denny Evans', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'546', N'Cook', N'Enoch_Norton8487@brety.org', N'Enoch Norton', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'547', N'Laboratory Technician', N'Blake_Casey1313@bungar.biz', N'Blake Casey', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'548', N'Project Manager', N'Michael_Gordon6649@bretoux.com', N'Michael Gordon', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'549', N'Call Center Representative', N'John_Carter2195@twipet.com', N'John Carter', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'550', N'Project Manager', N'Emmanuelle_Shelton7289@deavo.com', N'Emmanuelle Shelton', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'551', N'Bellman', N'Fred_Willson7386@ubusive.com', N'Fred Willson', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'552', N'Staffing Consultant', N'Christy_Styles2002@yahoo.com', N'Christy Styles', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'553', N'Treasurer', N'Enoch_Freeburn9620@typill.biz', N'Enoch Freeburn', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'554', N'Staffing Consultant', N'Marvin_Townend4311@mafthy.com', N'Marvin Townend', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'555', N'Assistant Buyer', N'Enoch_Wood2182@ubusive.com', N'Enoch Wood', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'556', N'Operator', N'Harry_Uddin9683@nickia.com', N'Harry Uddin', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'557', N'Executive Director', N'Michaela_Taylor2569@twipet.com', N'Michaela Taylor', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'558', N'Laboratory Technician', N'Vera_Bell9026@fuliss.net', N'Vera Bell', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'559', N'Clerk', N'Oliver_Thorpe7513@nickia.com', N'Oliver Thorpe', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'560', N'Treasurer', N'Daphne_Simpson7116@bulaffy.com', N'Daphne Simpson', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'561', N'Designer', N'Logan_Roberts1452@nanoff.biz', N'Logan Roberts', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'562', N'Healthcare Specialist', N'Oliver_Dickson2917@ubusive.com', N'Oliver Dickson', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'563', N'Healthcare Specialist', N'Vivian_Hope3131@yahoo.com', N'Vivian Hope', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'564', N'Food Technologist', N'Rick_Durrant16@womeona.net', N'Rick Durrant', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'565', N'Assistant Buyer', N'Andie_Amstead3854@infotech44.tech', N'Andie Amstead', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'566', N'Loan Officer', N'Enoch_Oakley8345@zorer.org', N'Enoch Oakley', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'567', N'Food Technologist', N'Rachael_Zaoui3227@grannar.com', N'Rachael Zaoui', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'568', N'Cook', N'Carmella_Antcliff8769@deons.tech', N'Carmella Antcliff', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'569', N'CNC Operator', N'Stephanie_Rainford6366@acrit.org', N'Stephanie Rainford', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'570', N'Clerk', N'Benjamin_Cartwright3746@gompie.com', N'Benjamin Cartwright', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'571', N'Service Supervisor', N'George_Osmond1545@naiker.biz', N'George Osmond', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'572', N'Staffing Consultant', N'Cristal_Sylvester9838@nanoff.biz', N'Cristal Sylvester', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'573', N'Baker', N'Leah_King8824@gompie.com', N'Leah King', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'574', N'Food Technologist', N'Rick_Martin5163@typill.biz', N'Rick Martin', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'575', N'Webmaster', N'George_Miller9861@gompie.com', N'George Miller', N'University of Texas at Austin')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'576', N'Business Broker', N'Daniel_Harris2980@brety.org', N'Daniel Harris', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'577', N'Bellman', N'Nick_Davies1877@grannar.com', N'Nick Davies', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'578', N'Physician', N'Domenic_Knight9885@zorer.org', N'Domenic Knight', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'579', N'Banker', N'Jayden_Lee9761@liret.org', N'Jayden Lee', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'580', N'Retail Trainee', N'Boris_Noach6025@nanoff.biz', N'Boris Noach', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'581', N'Doctor', N'Mike_Olson8460@grannar.com', N'Mike Olson', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'582', N'Fabricator', N'Adeline_Hill2506@acrit.org', N'Adeline Hill', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'583', N'Restaurant Manager', N'Russel_Noach6941@naiker.biz', N'Russel Noach', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'584', N'Call Center Representative', N'Roger_Phillips4986@iatim.tech', N'Roger Phillips', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'585', N'Global Logistics Supervisor', N'Esmeralda_Walker3907@zorer.org', N'Esmeralda Walker', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'586', N'Production Painter', N'Piper_Johnson3189@bungar.biz', N'Piper Johnson', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'587', N'Global Logistics Supervisor', N'Janice_Thompson8863@acrit.org', N'Janice Thompson', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'588', N'Healthcare Specialist', N'Ronald_Mann3762@deavo.com', N'Ronald Mann', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'589', N'Assistant Buyer', N'Brad_Watt9251@infotech44.tech', N'Brad Watt', N'Wake Forest University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'590', N'HR Coordinator', N'Dakota_Carson4688@twipet.com', N'Dakota Carson', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'591', N'Mobile Developer', N'Manuel_Ashley8558@bulaffy.com', N'Manuel Ashley', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'592', N'Bookkeeper', N'Harry_Hunter2808@grannar.com', N'Harry Hunter', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'593', N'Software Engineer', N'Carol_Baker1665@qater.org', N'Carol Baker', N'University of Texas Dallas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'594', N'Call Center Representative', N'Drew_James9737@brety.org', N'Drew James', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'595', N'Budget Analyst', N'Hayden_Simmons697@tonsy.org', N'Hayden Simmons', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'596', N'Fabricator', N'Bob_Donnelly7995@brety.org', N'Bob Donnelly', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'597', N'Software Engineer', N'Boris_Wright4143@supunk.biz', N'Boris Wright', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'598', N'Dentist', N'Paula_Swan4373@deons.tech', N'Paula Swan', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'599', N'Pharmacist', N'Ramon_Eyres1840@extex.org', N'Ramon Eyres', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'600', N'Machine Operator', N'Maxwell_Moss3535@jiman.org', N'Maxwell Moss', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'601', N'Fabricator', N'Aiden_Rycroft1157@extex.org', N'Aiden Rycroft', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'602', N'Pharmacist', N'Angelina_Pearson3317@elnee.tech', N'Angelina Pearson', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'603', N'Bellman', N'Livia_Olivier937@zorer.org', N'Livia Olivier', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'604', N'Budget Analyst', N'Martin_Myatt7365@iatim.tech', N'Martin Myatt', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'605', N'Mobile Developer', N'Ivette_Russell1349@liret.org', N'Ivette Russell', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'606', N'Front Desk Coordinator', N'Eduardo_Phillips1142@muall.tech', N'Eduardo Phillips', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'607', N'Doctor', N'Carmen_Tanner5669@kideod.biz', N'Carmen Tanner', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'608', N'Dentist', N'Madelyn_Brennan3868@bulaffy.com', N'Madelyn Brennan', N'University of California, Riverside')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'609', N'Service Supervisor', N'Raquel_Franks3590@jiman.org', N'Raquel Franks', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'610', N'Cashier', N'Martha_Norman2005@guentu.biz', N'Martha Norman', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'611', N'Designer', N'Nicholas_Jobson2262@guentu.biz', N'Nicholas Jobson', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'612', N'Cashier', N'Emerald_Varndell1770@fuliss.net', N'Emerald Varndell', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'613', N'Service Supervisor', N'Erick_Bowen3133@bretoux.com', N'Erick Bowen', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'614', N'Web Developer', N'Melania_Kennedy3797@guentu.biz', N'Melania Kennedy', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'615', N'Stockbroker', N'Esmeralda_Fields5633@twace.org', N'Esmeralda Fields', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'616', N'Healthcare Specialist', N'Jayden_Morris121@acrit.org', N'Jayden Morris', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'617', N'Food Technologist', N'Elijah_Poulton2619@typill.biz', N'Elijah Poulton', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'618', N'Executive Director', N'Chad_Reyes5847@eirey.tech', N'Chad Reyes', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'619', N'Baker', N'Analise_Broomfield147@vetan.org', N'Analise Broomfield', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'620', N'Business Broker', N'Gladys_James8697@tonsy.org', N'Gladys James', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'621', N'Cook', N'Logan_Bolton9600@famism.biz', N'Logan Bolton', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'622', N'Machine Operator', N'Keira_Harrington675@elnee.tech', N'Keira Harrington', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'623', N'Retail Trainee', N'Peter_Clark8930@zorer.org', N'Peter Clark', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'624', N'Pharmacist', N'Nicholas_Noach7353@zorer.org', N'Nicholas Noach', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'625', N'Health Educator', N'Destiny_Warner6304@corti.com', N'Destiny Warner', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'626', N'Service Supervisor', N'Rae_Fleming1837@gembat.biz', N'Rae Fleming', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'627', N'Software Engineer', N'Jenna_Morgan1832@ovock.tech', N'Jenna Morgan', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'628', N'Accountant', N'Martin_Cassidy3179@muall.tech', N'Martin Cassidy', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'629', N'Healthcare Specialist', N'Daron_Ventura1897@bulaffy.com', N'Daron Ventura', N'University of New Mexico')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'630', N'HR Specialist', N'Julian_Ellwood9229@gompie.com', N'Julian Ellwood', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'631', N'HR Coordinator', N'Denny_Connor6490@sveldo.biz', N'Denny Connor', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'632', N'Lecturer', N'Tyler_James9213@nimogy.biz', N'Tyler James', N'Rice University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'633', N'Loan Officer', N'Luke_Richardson8426@tonsy.org', N'Luke Richardson', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'634', N'Healthcare Specialist', N'Domenic_Roberts3112@corti.com', N'Domenic Roberts', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'635', N'HR Specialist', N'Clint_Brennan3687@joiniaa.com', N'Clint Brennan', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'636', N'Healthcare Specialist', N'Rosemary_Jackson5494@elnee.tech', N'Rosemary Jackson', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'637', N'Investment  Advisor', N'Ron_Vinton2249@ubusive.com', N'Ron Vinton', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'638', N'Cashier', N'Britney_Price3903@liret.org', N'Britney Price', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'639', N'Inspector', N'Winnie_Morley6243@ovock.tech', N'Winnie Morley', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'640', N'Mobile Developer', N'Mark_James2646@elnee.tech', N'Mark James', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'641', N'Fabricator', N'Catherine_Clarke7682@muall.tech', N'Catherine Clarke', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'642', N'Machine Operator', N'Julian_Spencer1436@dionrab.com', N'Julian Spencer', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'643', N'Ambulatory Nurse', N'Natalie_Clark1825@naiker.biz', N'Natalie Clark', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'644', N'Budget Analyst', N'Bryon_Dixon4631@bretoux.com', N'Bryon Dixon', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'645', N'Baker', N'Winnie_Bishop9163@mafthy.com', N'Winnie Bishop', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'646', N'Physician', N'Mike_Scott5809@qater.org', N'Mike Scott', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'647', N'Food Technologist', N'Leroy_Emerson8950@tonsy.org', N'Leroy Emerson', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'648', N'Business Broker', N'Ruth_Niles6221@hourpy.biz', N'Ruth Niles', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'649', N'Cashier', N'Melody_Mills3537@naiker.biz', N'Melody Mills', N'University of New Mexico')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'650', N'HR Specialist', N'Carl_Brooks4693@atink.com', N'Carl Brooks', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'651', N'Ambulatory Nurse', N'Denny_Rossi9440@liret.org', N'Denny Rossi', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'652', N'Dentist', N'Chad_Andrews1163@gembat.biz', N'Chad Andrews', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'653', N'Fabricator', N'Liam_Clarke7604@deons.tech', N'Liam Clarke', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'654', N'Chef Manager', N'Nicholas_Brooks597@jiman.org', N'Nicholas Brooks', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'655', N'Laboratory Technician', N'Zara_Bright295@acrit.org', N'Zara Bright', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'656', N'Doctor', N'Ruby_Barclay5969@liret.org', N'Ruby Barclay', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'657', N'Loan Officer', N'Lauren_Taylor5813@bauros.biz', N'Lauren Taylor', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'658', N'Associate Professor', N'Eduardo_Connor594@infotech44.tech', N'Eduardo Connor', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'659', N'Project Manager', N'Sylvia_Sheldon9669@liret.org', N'Sylvia Sheldon', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'660', N'Web Developer', N'Bridget_Glynn8546@bretoux.com', N'Bridget Glynn', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'661', N'Ambulatory Nurse', N'Rick_Ralph8716@womeona.net', N'Rick Ralph', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'662', N'Clerk', N'Wendy_Osmond5141@typill.biz', N'Wendy Osmond', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'663', N'Accountant', N'Anne_Cobb3958@cispeto.com', N'Anne Cobb', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'664', N'Business Broker', N'Hailey_Jeffery20@kideod.biz', N'Hailey Jeffery', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'665', N'Lecturer', N'Kenzie_Thompson4437@womeona.net', N'Kenzie Thompson', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'666', N'Cashier', N'Adeline_Mason4327@typill.biz', N'Adeline Mason', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'667', N'Ambulatory Nurse', N'Taylor_Hopkinson4215@irrepsy.com', N'Taylor Hopkinson', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'668', N'Chef Manager', N'Percy_Zaoui7991@typill.biz', N'Percy Zaoui', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'669', N'Stockbroker', N'Jacqueline_Kerr787@muall.tech', N'Jacqueline Kerr', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'670', N'Operator', N'Joseph_Glass2695@nanoff.biz', N'Joseph Glass', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'671', N'Designer', N'Mike_Roth7090@jiman.org', N'Mike Roth', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'672', N'Ambulatory Nurse', N'Ethan_Bailey9816@gembat.biz', N'Ethan Bailey', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'673', N'Project Manager', N'Brad_Wright7280@gembat.biz', N'Brad Wright', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'674', N'HR Specialist', N'Jaylene_Gilmore1472@deavo.com', N'Jaylene Gilmore', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'675', N'Software Engineer', N'Nathan_Bryson3060@famism.biz', N'Nathan Bryson', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'676', N'Design Engineer', N'Shannon_Bloom5352@yahoo.com', N'Shannon Bloom', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'677', N'Front Desk Coordinator', N'Adela_Forth4529@guentu.biz', N'Adela Forth', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'678', N'Staffing Consultant', N'Tyson_Marshall9632@irrepsy.com', N'Tyson Marshall', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'679', N'IT Support Staff', N'Teagan_Mcneill5505@eirey.tech', N'Teagan Mcneill', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'680', N'Systems Administrator', N'Hazel_Flynn1524@extex.org', N'Hazel Flynn', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'681', N'Bookkeeper', N'Diane_Harrison1764@extex.org', N'Diane Harrison', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'682', N'Bellman', N'Harmony_Powell8184@muall.tech', N'Harmony Powell', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'683', N'Inspector', N'Liliana_Vince5827@acrit.org', N'Liliana Vince', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'684', N'HR Coordinator', N'Kassandra_Saunders7812@supunk.biz', N'Kassandra Saunders', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'685', N'Service Supervisor', N'Tyson_Rothwell8997@guentu.biz', N'Tyson Rothwell', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'686', N'Paramedic', N'Sarah_Slater4772@kideod.biz', N'Sarah Slater', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'687', N'Front Desk Coordinator', N'Candace_Roscoe5840@elnee.tech', N'Candace Roscoe', N'University at Buffalo SUNY')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'688', N'Stockbroker', N'Ada_Purvis6436@hourpy.biz', N'Ada Purvis', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'689', N'Bellman', N'Elijah_Ashwell5968@acrit.org', N'Elijah Ashwell', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'690', N'Operator', N'Domenic_Preston7609@iatim.tech', N'Domenic Preston', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'691', N'Investment  Advisor', N'George_Barrett9028@mafthy.com', N'George Barrett', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'692', N'Software Engineer', N'Daria_Martin9570@twace.org', N'Daria Martin', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'693', N'Steward', N'Boris_Oldfield772@jiman.org', N'Boris Oldfield', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'694', N'Fabricator', N'Domenic_Lane952@joiniaa.com', N'Domenic Lane', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'695', N'Physician', N'Norah_Harper8016@sveldo.biz', N'Norah Harper', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'696', N'Bookkeeper', N'Rosalyn_Baldwin2322@supunk.biz', N'Rosalyn Baldwin', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'697', N'Inspector', N'Maxwell_Wood2172@gmail.com', N'Maxwell Wood', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'698', N'Software Engineer', N'Mason_Stewart3574@iatim.tech', N'Mason Stewart', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'699', N'Restaurant Manager', N'Wade_Clarke1784@nanoff.biz', N'Wade Clarke', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'700', N'Audiologist', N'Jacob_Saunders350@infotech44.tech', N'Jacob Saunders', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'701', N'Healthcare Specialist', N'Cassidy_Thatcher8821@irrepsy.com', N'Cassidy Thatcher', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'702', N'Web Developer', N'Sebastian_Faulkner428@atink.com', N'Sebastian Faulkner', N'Northeastern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'703', N'Restaurant Manager', N'Sofie_Parsons4732@cispeto.com', N'Sofie Parsons', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'704', N'Associate Professor', N'Jolene_Richardson2283@ubusive.com', N'Jolene Richardson', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'705', N'Stockbroker', N'Claire_Poulton3962@iatim.tech', N'Claire Poulton', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'706', N'Fabricator', N'Judith_Reading1543@sheye.org', N'Judith Reading', N'Johns Hopkins University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'707', N'Food Technologist', N'Carter_Vass223@eirey.tech', N'Carter Vass', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'708', N'Associate Professor', N'Fred_Mcneill4603@famism.biz', N'Fred Mcneill', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'709', N'Clerk', N'Kurt_Funnell1461@bretoux.com', N'Kurt Funnell', N'University of Texas Dallas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'710', N'Insurance Broker', N'Adelaide_Turner5080@ubusive.com', N'Adelaide Turner', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'711', N'Cashier', N'Doug_Anderson7513@corti.com', N'Doug Anderson', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'712', N'HR Specialist', N'Lindsay_Pitt799@typill.biz', N'Lindsay Pitt', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'713', N'Bookkeeper', N'Benjamin_Wilson5814@brety.org', N'Benjamin Wilson', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'714', N'Project Manager', N'Rocco_Cooper4597@jiman.org', N'Rocco Cooper', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'715', N'Associate Professor', N'Chris_Lomax9195@ovock.tech', N'Chris Lomax', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'716', N'Global Logistics Supervisor', N'Maia_Connor5580@famism.biz', N'Maia Connor', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'717', N'Paramedic', N'Hope_Rowlands4974@kideod.biz', N'Hope Rowlands', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'718', N'Dentist', N'Fred_Callan5924@famism.biz', N'Fred Callan', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'719', N'Fabricator', N'Janice_Nanton2282@famism.biz', N'Janice Nanton', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'720', N'Chef Manager', N'Johnathan_Redwood8434@ovock.tech', N'Johnathan Redwood', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'721', N'Baker', N'Vanessa_Wade6845@mafthy.com', N'Vanessa Wade', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'722', N'Baker', N'Melania_Roth8267@typill.biz', N'Melania Roth', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'723', N'Bookkeeper', N'Rae_Middleton9116@qater.org', N'Rae Middleton', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'724', N'Loan Officer', N'Makena_Turner107@bauros.biz', N'Makena Turner', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'725', N'Insurance Broker', N'Noah_Funnell4993@twace.org', N'Noah Funnell', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'726', N'Staffing Consultant', N'Karen_Holmes4547@kideod.biz', N'Karen Holmes', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'727', N'Baker', N'Dalia_Bentley2254@sheye.org', N'Dalia Bentley', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'728', N'Business Broker', N'Susan_Morris959@infotech44.tech', N'Susan Morris', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'729', N'Treasurer', N'Johnathan_Trent8447@nanoff.biz', N'Johnathan Trent', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'730', N'Project Manager', N'Dani_Middleton6915@twipet.com', N'Dani Middleton', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'731', N'Executive Director', N'Chelsea_Dillon3926@vetan.org', N'Chelsea Dillon', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'732', N'Steward', N'Carter_Fox9685@gembat.biz', N'Carter Fox', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'733', N'Dentist', N'Sara_York1537@cispeto.com', N'Sara York', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'734', N'Retail Trainee', N'Sonya_Cowan2787@acrit.org', N'Sonya Cowan', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'735', N'Bellman', N'Leilani_Buckley4860@atink.com', N'Leilani Buckley', N'University of Wisconsin-Madison')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'736', N'Health Educator', N'Audrey_Graham3700@vetan.org', N'Audrey Graham', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'737', N'Insurance Broker', N'Josh_Rose9744@bungar.biz', N'Josh Rose', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'738', N'Lecturer', N'Carter_Andersson7786@gembat.biz', N'Carter Andersson', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'739', N'Web Developer', N'Ema_Blythe2551@nickia.com', N'Ema Blythe', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'740', N'Service Supervisor', N'Leroy_Ogilvy525@elnee.tech', N'Leroy Ogilvy', N'Vanderbilt University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'741', N'Associate Professor', N'Tess_Healy8988@gmail.com', N'Tess Healy', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'742', N'Design Engineer', N'Boris_Dyson4110@tonsy.org', N'Boris Dyson', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'743', N'Restaurant Manager', N'Rosalee_Knight9372@brety.org', N'Rosalee Knight', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'744', N'Biologist', N'Logan_Rogan9517@muall.tech', N'Logan Rogan', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'745', N'Call Center Representative', N'Molly_Santos4992@brety.org', N'Molly Santos', N'University of California, Los Angeles (UCLA)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'746', N'Doctor', N'Sydney_Lane8423@nickia.com', N'Sydney Lane', N'North Carolina State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'747', N'Business Broker', N'Erick_Lambert4745@qater.org', N'Erick Lambert', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'748', N'Investment  Advisor', N'Enoch_Rogan7023@twipet.com', N'Enoch Rogan', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'749', N'Business Broker', N'Caydence_Morgan7152@twipet.com', N'Caydence Morgan', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'750', N'Design Engineer', N'Nathan_Tyrrell4548@dionrab.com', N'Nathan Tyrrell', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'751', N'Associate Professor', N'Rocco_Dowson677@bulaffy.com', N'Rocco Dowson', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'752', N'Bookkeeper', N'Quinn_Griffiths7932@yahoo.com', N'Quinn Griffiths', N'Boston University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'753', N'Biologist', N'Erick_Rigg4488@zorer.org', N'Erick Rigg', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'754', N'Steward', N'Jolene_Campbell3689@corti.com', N'Jolene Campbell', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'755', N'Chef Manager', N'Jolene_Taylor7927@womeona.net', N'Jolene Taylor', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'756', N'Banker', N'Agnes_Chapman3702@famism.biz', N'Agnes Chapman', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'757', N'Ambulatory Nurse', N'Allison_Santos2772@ubusive.com', N'Allison Santos', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'758', N'Clerk', N'Percy_Grant1950@gmail.com', N'Percy Grant', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'759', N'HR Coordinator', N'Maggie_Ramsey4208@eirey.tech', N'Maggie Ramsey', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'760', N'Design Engineer', N'Julianna_Walsh4848@elnee.tech', N'Julianna Walsh', N'University of California, Santa Barbara (UCSB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'761', N'Systems Administrator', N'Daphne_Allington8276@vetan.org', N'Daphne Allington', N'Texas A&M University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'762', N'IT Support Staff', N'Elijah_Coleman1660@typill.biz', N'Elijah Coleman', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'763', N'Stockbroker', N'Colleen_Evans1599@infotech44.tech', N'Colleen Evans', N'The University of Arizona')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'764', N'Pharmacist', N'Iris_Jarrett7894@gmail.com', N'Iris Jarrett', N'Rice University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'765', N'HR Specialist', N'Candice_Ellis9013@ovock.tech', N'Candice Ellis', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'766', N'Inspector', N'Carter_Rycroft7632@yahoo.com', N'Carter Rycroft', N'Howard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'767', N'Insurance Broker', N'Blake_Lee4481@nimogy.biz', N'Blake Lee', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'768', N'Audiologist', N'Lucas_Curtis4631@cispeto.com', N'Lucas Curtis', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'769', N'Doctor', N'Lucy_Gates2491@typill.biz', N'Lucy Gates', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'770', N'Cash Manager', N'Adalind_Wilson8471@fuliss.net', N'Adalind Wilson', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'771', N'Steward', N'Alan_Wilton9319@supunk.biz', N'Alan Wilton', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'772', N'Accountant', N'Johnathan_Tobin6745@corti.com', N'Johnathan Tobin', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'773', N'Cook', N'Nick_Murphy4500@elnee.tech', N'Nick Murphy', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'774', N'Systems Administrator', N'Johnny_Lomax2307@qater.org', N'Johnny Lomax', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'775', N'Cashier', N'Wendy_Rossi6895@elnee.tech', N'Wendy Rossi', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'776', N'Designer', N'Brooklyn_Leigh1200@extex.org', N'Brooklyn Leigh', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'777', N'Audiologist', N'Chanelle_Robinson3211@deons.tech', N'Chanelle Robinson', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'778', N'Stockbroker', N'Rocco_Gibson5677@fuliss.net', N'Rocco Gibson', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'779', N'Auditor', N'Josh_Weldon5476@iatim.tech', N'Josh Weldon', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'780', N'Assistant Buyer', N'Matthew_Saunders460@guentu.biz', N'Matthew Saunders', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'781', N'Mobile Developer', N'Noah_Turner4344@vetan.org', N'Noah Turner', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'782', N'Biologist', N'Eduardo_Waterson7533@deons.tech', N'Eduardo Waterson', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'783', N'Restaurant Manager', N'Rihanna_Alldridge4238@cispeto.com', N'Rihanna Alldridge', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'784', N'Project Manager', N'Clarissa_Speed3591@iatim.tech', N'Clarissa Speed', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'785', N'Inspector', N'Maribel_Attwood2045@nickia.com', N'Maribel Attwood', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'786', N'Loan Officer', N'Valentina_Owens4019@bretoux.com', N'Valentina Owens', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'787', N'Banker', N'Kurt_Veale5403@deons.tech', N'Kurt Veale', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'788', N'Mobile Developer', N'Hayden_Scott3666@atink.com', N'Hayden Scott', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'789', N'Dentist', N'Beatrice_Webster9744@ovock.tech', N'Beatrice Webster', N'Case Western Reserve University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'790', N'Front Desk Coordinator', N'Goldie_West4265@twipet.com', N'Goldie West', N'University of Texas at Austin')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'791', N'Fabricator', N'Ramon_Chadwick2078@atink.com', N'Ramon Chadwick', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'792', N'Project Manager', N'Enoch_Mitchell5378@ubusive.com', N'Enoch Mitchell', N'University of Texas at Austin')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'793', N'Machine Operator', N'Caitlyn_Coll5307@acrit.org', N'Caitlyn Coll', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'794', N'Cashier', N'Tyler_Shields3555@twipet.com', N'Tyler Shields', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'795', N'Restaurant Manager', N'Elisabeth_Blythe8003@gmail.com', N'Elisabeth Blythe', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'796', N'Paramedic', N'Trisha_Lynch9963@dionrab.com', N'Trisha Lynch', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'797', N'CNC Operator', N'Harmony_Ellwood6234@kideod.biz', N'Harmony Ellwood', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'798', N'CNC Operator', N'Fred_Douglas9536@supunk.biz', N'Fred Douglas', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'799', N'Loan Officer', N'Harry_Tanner8539@joiniaa.com', N'Harry Tanner', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'800', N'Cook', N'Danny_Selby9674@guentu.biz', N'Danny Selby', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'801', N'Pharmacist', N'Angel_Buckley2684@joiniaa.com', N'Angel Buckley', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'802', N'Treasurer', N'Kieth_Roscoe8465@ubusive.com', N'Kieth Roscoe', N'Florida State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'803', N'Mobile Developer', N'Rebecca_Broomfield9787@guentu.biz', N'Rebecca Broomfield', N'University of Pennsylvania')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'804', N'HR Specialist', N'Daron_Johnson6647@guentu.biz', N'Daron Johnson', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'805', N'Budget Analyst', N'Johnathan_Lewin5500@liret.org', N'Johnathan Lewin', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'806', N'Bellman', N'Chadwick_Phillips9748@vetan.org', N'Chadwick Phillips', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'807', N'Production Painter', N'Carl_Harris726@grannar.com', N'Carl Harris', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'808', N'Staffing Consultant', N'Jackeline_Grady24@kideod.biz', N'Jackeline Grady', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'809', N'Baker', N'Domenic_Hancock5284@muall.tech', N'Domenic Hancock', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'810', N'Cash Manager', N'Rhea_Lewis1002@tonsy.org', N'Rhea Lewis', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'811', N'Service Supervisor', N'Javier_Owen2898@dionrab.com', N'Javier Owen', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'812', N'Web Developer', N'Tony_Russell3388@kideod.biz', N'Tony Russell', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'813', N'Treasurer', N'Mason_Simpson7885@zorer.org', N'Mason Simpson', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'814', N'CNC Operator', N'Aurelia_Todd9594@vetan.org', N'Aurelia Todd', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'815', N'Project Manager', N'Olivia_Asher3450@kideod.biz', N'Olivia Asher', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'816', N'Machine Operator', N'Aleksandra_Vernon3737@deons.tech', N'Aleksandra Vernon', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'817', N'Investment  Advisor', N'Matt_Cunningham1874@elnee.tech', N'Matt Cunningham', N'University of Texas at Austin')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'818', N'Health Educator', N'Matthew_Richardson3312@gmail.com', N'Matthew Richardson', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'819', N'Dentist', N'George_Turner4580@bungar.biz', N'George Turner', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'820', N'Chef Manager', N'Rick_Roberts9984@ovock.tech', N'Rick Roberts', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'821', N'Electrician', N'Susan_Redden7735@liret.org', N'Susan Redden', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'822', N'Dentist', N'Harmony_Rehman1821@nimogy.biz', N'Harmony Rehman', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'823', N'Inspector', N'Carla_Baker899@muall.tech', N'Carla Baker', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'824', N'Chef Manager', N'Nathan_Daniells1545@grannar.com', N'Nathan Daniells', N'Georgia Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'825', N'Ambulatory Nurse', N'Hadley_Nicholls4819@bauros.biz', N'Hadley Nicholls', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'826', N'Auditor', N'Cedrick_Radley1305@gmail.com', N'Cedrick Radley', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'827', N'Cashier', N'George_Walsh2442@jiman.org', N'George Walsh', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'828', N'Inspector', N'Ramon_Mann2975@nimogy.biz', N'Ramon Mann', N'University of California, Riverside')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'829', N'IT Support Staff', N'Martha_Gardner6805@elnee.tech', N'Martha Gardner', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'830', N'Pharmacist', N'Christy_Mooney9412@elnee.tech', N'Christy Mooney', N'University of Notre Dame')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'831', N'Insurance Broker', N'Russel_Bishop2863@gompie.com', N'Russel Bishop', N'Yale University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'832', N'Stockbroker', N'Martin_Waterson2952@womeona.net', N'Martin Waterson', N'The Katz School at Yeshiva University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'833', N'Retail Trainee', N'Anabel_Logan608@infotech44.tech', N'Anabel Logan', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'834', N'Ambulatory Nurse', N'Eduardo_Bradshaw9374@twipet.com', N'Eduardo Bradshaw', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'835', N'CNC Operator', N'Ruth_Swan8345@mafthy.com', N'Ruth Swan', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'836', N'Cook', N'Greta_Jacobs1218@naiker.biz', N'Greta Jacobs', N'University of Chicago')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'837', N'Service Supervisor', N'Danny_Martin8939@cispeto.com', N'Danny Martin', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'838', N'Cashier', N'Clint_Chapman4513@elnee.tech', N'Clint Chapman', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'839', N'Cook', N'Rufus_Stone 2745@bretoux.com', N'Rufus Stone ', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'840', N'Pharmacist', N'Oliver_Thompson9383@ovock.tech', N'Oliver Thompson', N'Vanderbilt University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'841', N'Accountant', N'Gwen_Sawyer1856@acrit.org', N'Gwen Sawyer', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'842', N'Doctor', N'Ally_Quinton7846@deons.tech', N'Ally Quinton', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'843', N'Pharmacist', N'Faith_Penn1605@hourpy.biz', N'Faith Penn', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'844', N'Audiologist', N'Mason_Broomfield4784@eirey.tech', N'Mason Broomfield', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'845', N'Business Broker', N'Emma_Wilkinson5539@fuliss.net', N'Emma Wilkinson', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'846', N'Design Engineer', N'Melania_Pope944@bauros.biz', N'Melania Pope', N'Virginia Polytechnic Institute and State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'847', N'Audiologist', N'Daron_Vaughan2260@corti.com', N'Daron Vaughan', N'University of Miami')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'848', N'Web Developer', N'Henry_Hall1282@joiniaa.com', N'Henry Hall', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'849', N'Webmaster', N'Dasha_Knight1024@famism.biz', N'Dasha Knight', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'850', N'Fabricator', N'Roger_Kelly763@eirey.tech', N'Roger Kelly', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'851', N'Physician', N'Carissa_Rowlands732@extex.org', N'Carissa Rowlands', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'852', N'Front Desk Coordinator', N'Freya_Hudson7476@vetan.org', N'Freya Hudson', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'853', N'Operator', N'Shay_Bright5979@irrepsy.com', N'Shay Bright', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'854', N'Operator', N'Gemma_Collins7009@deons.tech', N'Gemma Collins', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'855', N'Doctor', N'Leroy_Burge2528@irrepsy.com', N'Leroy Burge', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'856', N'Inspector', N'Fred_Mccall4107@infotech44.tech', N'Fred Mccall', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'857', N'Global Logistics Supervisor', N'Alice_Gilmore4522@ovock.tech', N'Alice Gilmore', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'858', N'Auditor', N'Gladys_Griffiths7718@vetan.org', N'Gladys Griffiths', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'859', N'Budget Analyst', N'Leilani_Gray9131@grannar.com', N'Leilani Gray', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'860', N'Steward', N'Savannah_Giles1226@cispeto.com', N'Savannah Giles', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'861', N'IT Support Staff', N'Jacob_Mason5012@tonsy.org', N'Jacob Mason', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'862', N'Business Broker', N'Vivian_Ebden1352@ovock.tech', N'Vivian Ebden', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'863', N'IT Support Staff', N'Ron_Emerson8603@joiniaa.com', N'Ron Emerson', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'864', N'Call Center Representative', N'Julius_Owen4090@gembat.biz', N'Julius Owen', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'865', N'Front Desk Coordinator', N'Jane_Hill4453@fuliss.net', N'Jane Hill', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'866', N'Audiologist', N'Mark_Hale4332@gembat.biz', N'Mark Hale', N'Michigan State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'867', N'Audiologist', N'Britney_Hall6101@nickia.com', N'Britney Hall', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'868', N'Chef Manager', N'Matt_Porter1053@twace.org', N'Matt Porter', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'869', N'Executive Director', N'Julius_Drake9782@nickia.com', N'Julius Drake', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'870', N'Bookkeeper', N'Lindsay_Shields9476@vetan.org', N'Lindsay Shields', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'871', N'Baker', N'Barry_Shields1922@grannar.com', N'Barry Shields', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'872', N'Budget Analyst', N'Fred_Clark5295@tonsy.org', N'Fred Clark', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'873', N'Operator', N'Gil_White8619@bulaffy.com', N'Gil White', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'874', N'Production Painter', N'Ethan_Thomas5445@yahoo.com', N'Ethan Thomas', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'875', N'Retail Trainee', N'Gloria_Wilde691@infotech44.tech', N'Gloria Wilde', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'876', N'Treasurer', N'Susan_Jefferson5805@grannar.com', N'Susan Jefferson', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'877', N'CNC Operator', N'Mark_Brown4815@corti.com', N'Mark Brown', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'878', N'Service Supervisor', N'Sarah_Spencer6897@eirey.tech', N'Sarah Spencer', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'879', N'Bellman', N'Grace_Turner5211@eirey.tech', N'Grace Turner', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'880', N'Biologist', N'Charlize_Thompson2130@gmail.com', N'Charlize Thompson', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'881', N'Doctor', N'Tyson_Blackburn3770@extex.org', N'Tyson Blackburn', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'882', N'HR Coordinator', N'Marie_Hewitt5495@zorer.org', N'Marie Hewitt', N'Columbia University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'883', N'Global Logistics Supervisor', N'Madelyn_Franks7223@acrit.org', N'Madelyn Franks', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'884', N'Service Supervisor', N'Rosemary_Power2986@deons.tech', N'Rosemary Power', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'885', N'Restaurant Manager', N'Thea_Vinton1185@infotech44.tech', N'Thea Vinton', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'886', N'Loan Officer', N'Gladys_Hunt2571@muall.tech', N'Gladys Hunt', N'University of Rochester')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'887', N'Inspector', N'Logan_Howard3707@typill.biz', N'Logan Howard', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'888', N'Budget Analyst', N'Aurelia_Roberts195@mafthy.com', N'Aurelia Roberts', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'889', N'Restaurant Manager', N'Alexa_Allington9048@qater.org', N'Alexa Allington', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'890', N'Bellman', N'Kurt_Kaur9097@hourpy.biz', N'Kurt Kaur', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'891', N'Bookkeeper', N'Ally_Edmonds6919@twace.org', N'Ally Edmonds', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'892', N'Electrician', N'Gloria_Brooks2698@sheye.org', N'Gloria Brooks', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'893', N'Auditor', N'Courtney_Steer3645@vetan.org', N'Courtney Steer', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'894', N'Clerk', N'Alan_Stewart8129@qater.org', N'Alan Stewart', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'895', N'Systems Administrator', N'Michael_Thompson9773@jiman.org', N'Michael Thompson', N'Purdue University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'896', N'HR Specialist', N'Gabriel_Middleton4730@muall.tech', N'Gabriel Middleton', N'Massachusets Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'897', N'Fabricator', N'Chester_Chapman734@qater.org', N'Chester Chapman', N'University of Oklahoma')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'898', N'HR Specialist', N'Ada_Lloyd2178@corti.com', N'Ada Lloyd', N'University of Maryland, College Park')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'899', N'Stockbroker', N'Percy_Faulkner2685@gembat.biz', N'Percy Faulkner', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'900', N'Mobile Developer', N'Juliette_Cattell5022@gmail.com', N'Juliette Cattell', N'University of Illinois, Chicago (UIC)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'901', N'Insurance Broker', N'Mavis_Underhill9739@sheye.org', N'Mavis Underhill', N'Cornell University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'902', N'Steward', N'Fred_Kennedy105@twipet.com', N'Fred Kennedy', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'903', N'Retail Trainee', N'Celia_Riley7827@yahoo.com', N'Celia Riley', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'904', N'Auditor', N'Chad_Goldsmith4403@womeona.net', N'Chad Goldsmith', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'905', N'Executive Director', N'Nate_Stark4750@bretoux.com', N'Nate Stark', N'University of Pittsburgh')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'906', N'Budget Analyst', N'Phillip_Little7118@sheye.org', N'Phillip Little', N'Princeton University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'907', N'Ambulatory Nurse', N'Tony_Page 9157@sveldo.biz', N'Tony Page ', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'908', N'Budget Analyst', N'Jacqueline_Clifton3489@gembat.biz', N'Jacqueline Clifton', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'909', N'Accountant', N'Julius_Buckley2465@nimogy.biz', N'Julius Buckley', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'910', N'Baker', N'Javier_Butler9697@vetan.org', N'Javier Butler', N'University of Colorado, Denver')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'911', N'Investment  Advisor', N'Clint_Glass2463@qater.org', N'Clint Glass', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'912', N'Cashier', N'Adalie_Thomson4182@irrepsy.com', N'Adalie Thomson', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'913', N'Treasurer', N'Holly_Ellery1063@cispeto.com', N'Holly Ellery', N'University of California, Riverside')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'914', N'CNC Operator', N'Hanna_Edmonds852@guentu.biz', N'Hanna Edmonds', N'Rensselaer Polytechnic University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'915', N'CNC Operator', N'Julian_Emmett4893@vetan.org', N'Julian Emmett', N'Carnegie Mellon University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'916', N'Bellman', N'Selena_Corbett3578@jiman.org', N'Selena Corbett', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'917', N'Global Logistics Supervisor', N'Janelle_Sloan2165@vetan.org', N'Janelle Sloan', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'918', N'Accountant', N'Lucas_Reid1109@deons.tech', N'Lucas Reid', N'University of Maryland, Baltimore County')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'919', N'Treasurer', N'Blake_Morris9749@deons.tech', N'Blake Morris', N'University of California, Berkeley (UCB)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'920', N'Doctor', N'Madelyn_Brooks8661@grannar.com', N'Madelyn Brooks', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'921', N'Retail Trainee', N'Lynn_Bowen2334@deons.tech', N'Lynn Bowen', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'922', N'Assistant Buyer', N'Martin_Kerr2673@dionrab.com', N'Martin Kerr', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'923', N'Cashier', N'Aurelia_Gray5209@twipet.com', N'Aurelia Gray', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'924', N'Project Manager', N'Melania_Penn1893@hourpy.biz', N'Melania Penn', N'Pennsylvania State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'925', N'Chef Manager', N'Emmanuelle_Jenkin557@elnee.tech', N'Emmanuelle Jenkin', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'926', N'Ambulatory Nurse', N'Livia_Thomas9863@tonsy.org', N'Livia Thomas', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'927', N'CNC Operator', N'Mark_Knight63@yahoo.com', N'Mark Knight', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'928', N'Staffing Consultant', N'Jazmin_Isaac2768@qater.org', N'Jazmin Isaac', N'University of Illinois at Urbana-Champaign')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'929', N'Dentist', N'Chadwick_Quinton2708@grannar.com', N'Chadwick Quinton', N'University of Virginia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'930', N'Global Logistics Supervisor', N'Clint_Jenkins6531@nimogy.biz', N'Clint Jenkins', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'931', N'CNC Operator', N'Rufus_Buckley945@bungar.biz', N'Rufus Buckley', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'932', N'Call Center Representative', N'Carol_Butler7906@extex.org', N'Carol Butler', N'Brown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'933', N'Design Engineer', N'Liv_Hall5807@tonsy.org', N'Liv Hall', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'934', N'Global Logistics Supervisor', N'Alexander_Vane6371@acrit.org', N'Alexander Vane', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'935', N'Bookkeeper', N'Camila_Stewart3531@atink.com', N'Camila Stewart', N'University of Colorado Boulder')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'936', N'Project Manager', N'Harvey_Poulton9173@irrepsy.com', N'Harvey Poulton', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'937', N'Executive Director', N'Kimberly_Emerson5586@sveldo.biz', N'Kimberly Emerson', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'938', N'Webmaster', N'Jack_Nicolas4954@mafthy.com', N'Jack Nicolas', N'University of Utah')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'939', N'Electrician', N'Elly_Allcott5709@jiman.org', N'Elly Allcott', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'940', N'Designer', N'Clarissa_Murphy8458@iatim.tech', N'Clarissa Murphy', N'Colorado State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'941', N'Web Developer', N'Andrea_Wilde7130@zorer.org', N'Andrea Wilde', N'Clark University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'942', N'CNC Operator', N'Fiona_Allington2538@corti.com', N'Fiona Allington', N'University of Iowa')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'943', N'Pharmacist', N'Jayden_Rowe5573@acrit.org', N'Jayden Rowe', N'University of New Mexico')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'944', N'Food Technologist', N'Julian_Devonport2062@eirey.tech', N'Julian Devonport', N'Washington University in St. Louis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'945', N'Bellman', N'Angelique_Vernon4797@bungar.biz', N'Angelique Vernon', N'University of Southern California')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'946', N'Operator', N'Phoebe_Dubois7196@bauros.biz', N'Phoebe Dubois', N'University of Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'947', N'Lecturer', N'Eryn_Quinn7704@fuliss.net', N'Eryn Quinn', N'University of South Florida')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'948', N'Mobile Developer', N'Rosie_Stevenson2651@deons.tech', N'Rosie Stevenson', N'Indiana University Bloomington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'949', N'Paramedic', N'Nicholas_Payne6252@bretoux.com', N'Nicholas Payne', N'University of California, Irvine')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'950', N'Web Developer', N'Chadwick_Larkin5696@bauros.biz', N'Chadwick Larkin', N'Washington State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'951', N'Paramedic', N'Henry_Coll6060@atink.com', N'Henry Coll', N'University of Massachusetts Amherst')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'952', N'Design Engineer', N'Gabriel_Carter2400@ovock.tech', N'Gabriel Carter', N'University of California, Santa Cruz')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'953', N'IT Support Staff', N'Tyson_Mullins8358@nanoff.biz', N'Tyson Mullins', N'Wayne State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'954', N'Steward', N'John_Flack4397@vetan.org', N'John Flack', N'University of Delaware')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'955', N'HR Specialist', N'Adeline_Patel2500@nickia.com', N'Adeline Patel', N'Iowa State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'956', N'Webmaster', N'Victoria_Atkinson9419@liret.org', N'Victoria Atkinson', N'Rutgers University - New Brunswick')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'957', N'Cash Manager', N'Henry_Martin3688@atink.com', N'Henry Martin', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'958', N'Banker', N'Gemma_Upsdell5797@hourpy.biz', N'Gemma Upsdell', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'959', N'Systems Administrator', N'Dakota_Mcnally5402@bungar.biz', N'Dakota Mcnally', N'Brandeis University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'960', N'Staffing Consultant', N'Fiona_Windsor2724@cispeto.com', N'Fiona Windsor', N'The University of Georgia')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'961', N'CNC Operator', N'Diane_Clayton9416@ubusive.com', N'Diane Clayton', N'California Institute of Technology (Caltech)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'962', N'Retail Trainee', N'Danny_Glass4606@twipet.com', N'Danny Glass', N'Emory University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'963', N'Food Technologist', N'Juliette_Spencer8457@iatim.tech', N'Juliette Spencer', N'New York University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'964', N'Assistant Buyer', N'Aiden_Bentley2979@sheye.org', N'Aiden Bentley', N'Boston College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'965', N'Operator', N'Domenic_Forth6443@muall.tech', N'Domenic Forth', N'University of North Carolina, Chapel Hill')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'966', N'HR Specialist', N'Alexander_Lee5041@hourpy.biz', N'Alexander Lee', N'Rice University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'967', N'Project Manager', N'Charlotte_Rivers6377@acrit.org', N'Charlotte Rivers', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'968', N'Bookkeeper', N'Nicholas_Bright8801@bulaffy.com', N'Nicholas Bright', N'George Washington University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'969', N'Pharmacist', N'Aiden_Griffiths5454@eirey.tech', N'Aiden Griffiths', N'Illinois Institute of Technology')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'970', N'Cashier', N'Chuck_Tindall6401@guentu.biz', N'Chuck Tindall', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'971', N'Biologist', N'William_Tobin8039@bungar.biz', N'William Tobin', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'972', N'Ambulatory Nurse', N'Carmen_Adler4178@bungar.biz', N'Carmen Adler', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'973', N'Dentist', N'Mason_Stewart7481@womeona.net', N'Mason Stewart', N'University of Connecticut')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'974', N'Design Engineer', N'Kieth_Ward5754@infotech44.tech', N'Kieth Ward', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'975', N'Laboratory Technician', N'Brad_Noach4723@atink.com', N'Brad Noach', N'University of Michigan')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'976', N'Cash Manager', N'Roger_Webster9830@atink.com', N'Roger Webster', N'Duke University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'977', N'Designer', N'Ramon_Herbert3163@deavo.com', N'Ramon Herbert', N'University of Vermont')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'978', N'Cashier', N'Deborah_Underhill3653@joiniaa.com', N'Deborah Underhill', N'Drexel University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'979', N'Project Manager', N'Nina_Plant9517@guentu.biz', N'Nina Plant', N'University of California, Davis')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'980', N'Pharmacist', N'Carla_Emmett7730@sheye.org', N'Carla Emmett', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'981', N'Lecturer', N'Julius_Matthews3779@sveldo.biz', N'Julius Matthews', N'Harvard University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'982', N'HR Specialist', N'Rosa_Brennan2673@bungar.biz', N'Rosa Brennan', N'Oregon State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'983', N'Retail Trainee', N'Penelope_Wright7569@corti.com', N'Penelope Wright', N'University of Kansas')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'984', N'Assistant Buyer', N'Denis_Rodgers2607@iatim.tech', N'Denis Rodgers', N'Dartmouth College')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'985', N'Accountant', N'Macy_Ryan9265@gmail.com', N'Macy Ryan', N'Stony Brook University, State University of New York')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'986', N'Front Desk Coordinator', N'Sage_Powell2902@sheye.org', N'Sage Powell', N'The University of Tennessee, Knoxville')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'987', N'Budget Analyst', N'Doug_Stewart9546@irrepsy.com', N'Doug Stewart', N'Stanford University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'988', N'Budget Analyst', N'Alexander_Leslie2951@dionrab.com', N'Alexander Leslie', N'Northwestern University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'989', N'Operator', N'Boris_Harrington4719@guentu.biz', N'Boris Harrington', N'The New School')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'990', N'Call Center Representative', N'Fred_Tobin5544@yahoo.com', N'Fred Tobin', N'University of California, San Diego (UCSD)')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'991', N'CNC Operator', N'Percy_Stuart7177@sheye.org', N'Percy Stuart', N'The Ohio State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'992', N'Paramedic', N'Erin_Mills1675@bungar.biz', N'Erin Mills', N'Georgetown University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'993', N'Design Engineer', N'Caleb_Sherry3077@bulaffy.com', N'Caleb Sherry', N'Lehigh University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'994', N'Ambulatory Nurse', N'Liam_Allwood8788@yahoo.com', N'Liam Allwood', N'Arizona State University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'995', N'Investment  Advisor', N'Nate_Addley4392@gmail.com', N'Nate Addley', N'University of Minnesota')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'996', N'Machine Operator', N'Jazmin_Norton3044@bretoux.com', N'Jazmin Norton', N'University of Washington')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'997', N'Ambulatory Nurse', N'Harvey_Dyson9559@typill.biz', N'Harvey Dyson', N'University of Hawai')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'998', N'Web Developer', N'Danny_Parr1211@eirey.tech', N'Danny Parr', N'Tulane University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'999', N'Associate Professor', N'Owen_Walton7266@guentu.biz', N'Owen Walton', N'Tufts University')
GO
GO
INSERT INTO [dbo].[T_Users] ([ID], [JobTitle], [EmailAddress], [FirstNameLastName], [Newcolumn]) VALUES (N'1000', N'HR Specialist', N'Noah_Parker5661@jiman.org', N'Noah Parker', N'University of Texas at Austin')
GO
GO

-- ----------------------------
-- Indexes structure for table T_Users
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table T_Users
-- ----------------------------
ALTER TABLE [dbo].[T_Users] ADD PRIMARY KEY ([ID])
GO
