--------------------------------------
--------------菜单表-------------------
---------------------------------------
select * from ui_menu
create table ui_menu
(
	id int  identity(1,1),
	menuorder int,
	fatherid int ,          --0 为主菜单
	menuname nvarchar(50),
	icon nvarchar(50),
	url nvarchar(200),
	crdate datetime default getdate()
)
--------------------------------------
--------------角色表-------------------
---------------------------------------
select * from  ui_role
--drop table ui_role
create table ui_role --角色表
(
	id uniqueidentifier primary key,
	rolename nvarchar(50),
	beizhu nvarchar(100),
	crdate datetime default getdate()
)

--------------------------------------
--------------菜单角色对应表-------------------
---------------------------------------
select * from   ui_role_menu
 create table ui_role_menu 
(
	id int  identity(1,1),
	ui_role_id uniqueidentifier,
	ui_menu_id int,
	crdate datetime default getdate()
)



--------------------------------------
--------------组织机构表-------------------
---------------------------------------
select * from  ui_org
create table ui_org
(
	id uniqueidentifier primary key,
	fatherid uniqueidentifier,
	orgcode nvarchar(30),
	orgname nvarchar(50),
	icon varchar(20),
	attr_a nvarchar(30),
	attr_b nvarchar(30),
	crdate datetime
)

--------------------------------------
--------------用户表-------------------
---------------------------------------
select * from  ui_user
create table ui_user
(
	id uniqueidentifier primary key,
	account nvarchar(30),
	password nvarchar(36),
	xingming nvarchar(30),
	sex nvarchar(1)	,
	birth nvarchar(10),
	sfz varchar(20),
	tel varchar(15),
	dizhi nvarchar(100),
	email varchar(50),
	qq varchar(15),
	crdate datetime

)

--------------------------------------
----------------用户 角色 对应表-------------------
---------------------------------------
create table ui_user_role 
(
	id int  identity(1,1),
	ui_user_id uniqueidentifier,
	ui_role_id uniqueidentifier,
	crdate datetime 
)

--------------------------------------
------------------用户 角色 对应表-------------------
---------------------------------------
create table ui_user_org 
(
	id int  identity(1,1),
	ui_user_id uniqueidentifier,
	ui_org_id uniqueidentifier,
	crdate datetime 
)

--------------------------------------
------------------菜单角色对应视图-------------------
---------------------------------------
SELECT     r.id AS ui_role_id, r.rolename, m.id AS 
ui_menu_id, m.menuorder, m.fatherid, m.menuname, m.icon, m.url, 
CASE WHEN isnull(rm.id, 0) = 0 THEN 'false' ELSE 'true' END AS roleright
FROM dbo.ui_role AS r CROSS JOIN
dbo.ui_menu AS m LEFT OUTER JOIN
dbo.ui_role_menu AS rm ON r.id = rm.ui_role_id AND m.id = rm.ui_menu_id