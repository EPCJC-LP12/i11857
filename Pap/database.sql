CREATE TABLE news (
	news_id INTEGER PRIMARY KEY AUTOINCREMENT,
	title VARCHAR,
	text VARCHAR,
	user_id INTEGER REFERENCES users,
	username VARCHAR,
	url VARCHAR,
	t DATETIME
);

CREATE TABLE comments (
	comments_id INTEGER PRIMARY KEY AUTOINCREMENT,
	news_id INTEGER REFERENCES news,
	autor INTEGER REFERENCES users,
	text VARCHAR
);

CREATE TABLE users (
	user_id INTEGER PRIMARY KEY AUTOINCREMENT,
	username VARCHAR,
	fullname VARCHAR,
	password VARCHAR,
	type INTEGER,
	status VARCHAR
);
CREATE TABLE favoritos(
	favoritos_id INTEGER PRIMARY KEY AUTOINCREMENT,
	user_id INTEGER REFERENCES users,
	news_id INTEGER REFERENCES news
);

CREATE TABLE tags(
	tags_id INTEGER PRIMARY KEY AUTOINCREMENT,
	news_id INTEGER REFERENCES news,
	tag VARCHAR
);

CREATE TABLE servers(
	servers_id INTEGER PRIMARY KEY AUTOINCREMENT,
	name VARCHAR,
	url VARCHAR
);
