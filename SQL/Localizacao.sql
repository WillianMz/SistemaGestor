/*Localização geografica*/
CREATE TABLE local_pais(
	id int primary key,
	nome varchar(150) not null
);

CREATE TABLE local_uf(
	id int primary key,
	nome varchar(100) not null,
	id_pais int not null,
	constraint fk_local_pais foreign key(id_pais) references local_pais(id) ON DELETE CASCADE ON UPDATE
);

CREATE TABLE local_cidade(
	id int primary key,
	nome varchar(100) not null,
	id_uf int not null,
	constraint fk_local_uf foreign key(id_uf) references local_uf(id)  ON DELETE CASCADE ON UPDATE
);