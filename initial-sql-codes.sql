CREATE TABLE [dbo].[Payments] (
[id]			    		INT				IDENTITY (1, 1) NOT NULL,
[amount]		    		INT				NOT NULL,
[payment_due_date]  		DATE			NULL,
[description]				VARCHAR (160)	NULL,
[is_paid]					BIT				NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
);

CREATE TABLE [dbo].[Permissions] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[facility_access_level]		SMALLINT		NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
);

CREATE TABLE [dbo].[Members] (
[id]						INT				IDENTITY (1, 1) NOT NULL,
[payment_id]				INT           	NOT NULL,
[permission_id]				INT           	NOT NULL,
[name] 						VARCHAR (25)  	NOT NULL,
[surname]					VARCHAR (25)  	NOT NULL,
[gender]					CHAR (1)      	NOT NULL,
[age]						SMALLINT      	NOT NULL,
[email]						VARCHAR (75)  	NULL,
[phone_number]				BIGINT        	NULL,
[address]					VARCHAR (160) 	NULL,
[height]					SMALLINT      	NULL,
[weight]					SMALLINT      	NULL,
[birth_date]				DATE          	NOT NULL,
[date_joined]				DATE          	NOT NULL,
[membership_expiry_date]	DATE          	NOT NULL,
[weekly_entrance_right]		SMALLINT      	NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (payment_id) REFERENCES Payments(id),
FOREIGN KEY (permission_id) REFERENCES Permissions(id),
);

CREATE TABLE [dbo].[Roles] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[permission_id]				INT				NOT NULL,
[role]						VARCHAR (25)		NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (permission_id) REFERENCES Permissions(id),
);

CREATE TABLE [dbo].[Employees] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[employee_id]				INT				NOT NULL,
[amount]					INT				NULL,
[date]						DATE			NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (employee_id) REFERENCES Employees(id),
);

CREATE TABLE [dbo].[LoginHistory] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[username]					VARCHAR (25)	NULL,
[event]						VARCHAR (MAX)	NULL,
[employee_id]				INT				NULL,
[log_details]				VARCHAR (MAX)	NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (employee_id) REFERENCES Employees(id),
);

CREATE TABLE [dbo].[WageAmounts] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[amount]					INT				NOT NULL,
[employee_id]				INT				NOT NULL,
[date]						DATE			NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
);

CREATE TABLE [dbo].[MemberImprovements] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[member_id]					INT				NOT NULL,
[weight]					SMALLINT		NULL,
[height]					SMALLINT		NULL,
[date]						DATE			NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (member_id) REFERENCES Members(id),
);

CREATE TABLE [dbo].[Memberships] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[member_id]					INT				NOT NULL,
[new_payment_id]			INT				NULL,
[new_expiry_date]			DATE			NULL,
[new_entrance_right]		INT				NULL,
[wage_amount_id]			INT				NOT NULL,
[permission_id]				INT				NOT NULL,
[role_id]					INT				NOT NULL,
[name]                  	VARCHAR (25)	NOT NULL,
[surname]               	VARCHAR (25)	NOT NULL,
[gender]                	CHAR (1)		NOT NULL,
[age]                   	SMALLINT		NOT NULL,
[email]                 	VARCHAR (75)	NULL,
[phone_number]          	BIGINT			NULL,
[address]               	VARCHAR (160)	NULL,
[height]                	SMALLINT		NULL,
[weight]                	SMALLINT		NULL,
[birth_date]            	DATE			NOT NULL,
[date_joined]				DATE			NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (member_id) REFERENCES Members(id),
FOREIGN KEY (new_payment_id) REFERENCES Payments(id),
FOREIGN KEY (wage_amount_id) REFERENCES WageAmounts(id),
FOREIGN KEY (permission_id) REFERENCES Permissions(id),
FOREIGN KEY (role_id) REFERENCES Roles(id),
);

CREATE TABLE [dbo].[Equipments] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[equipment_type]			VARCHAR	(MAX)	NOT NULL,
[price]						INT				NULL,
[condition]					SMALLINT		NULL,
[date_of_arrival]			DATE			NULL,
[warranty]					DATE			NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
);

CREATE TABLE [dbo].[Facilities] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[permission_id] 			INT				NOT NULL,
[name]						VARCHAR (25) 	NOT NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (permission_id) REFERENCES Permissions(id),
);

CREATE TABLE [dbo].[Courses] (
[id]						INT				IDENTITY (1,1) NOT NULL,
[employee_id]				INT				NOT NULL,
[name]						VARCHAR (25)	NOT NULL,
[description]				VARCHAR (160)	NULL,
PRIMARY KEY CLUSTERED ([id] ASC),
FOREIGN KEY (employee_id) REFERENCES Employees(id),
);