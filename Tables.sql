CREATE TABLE [dbo].[States] (
	[id]   INT          IDENTITY (1, 1) NOT NULL,
	[name] VARCHAR (25) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[AnOrders] (
	[id]            INT           IDENTITY (1, 1) NOT NULL,
	[customer_name] VARCHAR (25)  NOT NULL,
	[description]   VARCHAR (255) NOT NULL,
	[created_at]    DATE          NOT NULL,
	[state_id]      INT           NULL,
	PRIMARY KEY CLUSTERED ([id] ASC),
	FOREIGN KEY ([state_id]) REFERENCES [dbo].[States] ([id])
);