/* PESSOAS (CLIENTE/FORNECEDOR/TRANSP./FUNCIONARIO/OUTROS) -----------------------*/
CREATE TABLE pessoa_tipo(
	id int primary key,
	nome varchar(15) not null
);

INSERT INTO pessoa_tipo(id,nome) VALUES(1,'Jurídica');
INSERT INTO pessoa_tipo(id,nome) VALUES(2,'Física');


CREATE SEQUENCE seq_pessoa INCREMENT 1 START 1;
CREATE TABLE pessoa(
	id int primary key default nextval('seq_pessoa'),
	ativo boolean default true,
	id_tipo int not null,
	cliente boolean,
	fornecedor boolean,
	funcionario boolean,
	transportador boolean,
	outro boolean,
	cpf_cnpj varchar(20) not null unique,
	nome_completo varchar(200) not null,
	fantasia varchar(150),
	rg_ie varchar(15),	
	/*endereço principal da pessoa*/
	cep varchar(10) not null,
	id_pais integer   default null,
	id_uf integer     default null,
	id_cidade integer default null,
	bairro varchar(50) not null,
	logradouro varchar(100) not null,
	numero integer not null default 0,
	complemento varchar(40) null,
	/*contato da pessoa*/
	telefone varchar(15),
	celular varchar(15),
	contato varchar(100) not null,
	email varchar(150) null,
	dt_nasc date,
	dt_cadastro timestamp not null,
	dt_alteracao timestamp,

	constraint fk_pessoa_tipo   foreign key(id_tipo)   references pessoa_tipo(id),
	constraint fk_pessoa_pais   foreign key(id_pais)   references local_pais(id)   ON DELETE SET DEFAULT,
	constraint fk_pessoa_uf     foreign key(id_uf)     references local_uf(id)     ON DELETE SET DEFAULT,
	constraint fk_pessoa_cidade foreign key(id_cidade) references local_cidade(id) ON DELETE SET DEFAULT
);

CREATE SEQUENCE seq_pessoa_cliente INCREMENT 1 START 1;
CREATE TABLE pessoa_cliente(
	id primary key default nextval('seq_pessoa_cliente'),
	id_pessoa int not null,
	constraint fk_cliente_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_fornec INCREMENT 1 START 1;
CREATE TABLE pessoa_fornecedor(
	id primary key default nextval('seq_pessoa_fornec'),
	id_pessoa int not null,
	constraint fk_fornec_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_transp INCREMENT 1 START 1;
CREATE TABLE pessoa_transp(
	id primary key default nextval('seq_pessoa_transp'),
	id_pessoa int not null,
	constraint fk_transp_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_func INCREMENT 1 START 1;
CREATE TABLE pessoa_funcionario(
	id primary key default nextval('seq_pessoa_func'),
	id_pessoa int not null,
	constraint fk_func_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_outro INCREMENT 1 START 1;
CREATE TABLE pessoa_outro(
	id primary key default nextval('seq_pessoa_outro'),
	id_pessoa int not null,
	constraint fk_outro_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_vendedor INCREMENT 1 START 1;
CREATE TABLE pessoa_vendedor(
	id primary key default nextval('seq_pessoa_vendedor'),
	id_pessoa int not null,
	constraint fk_vendedor_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_pessoa_endereco INCREMENT 1 START 1;
CREATE TABLE pessoa_endereco(
	id int primary key default nextval('seq_pessoa_endereco'),
	id_pessoa int not null,
	principal boolean,
	nome varchar(30) not null,
	cep int not null,
	id_pais	int not null,
	id_uf int not null,
	id_cidade int not null,
	logradouro varchar(100) not null,
	numero int not null,
	complemento varchar(40) null,
	constraint fk_pendereco_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE,
	constraint fk_pendereco_pais   foreign key(id_pais) references local_pais(id),
	constraint fk_pendereco_uf 	  foreign key(id_uf) references local_uf(id),
	constraint fk_pendereco_cidade foreign key(id_cidade) references local_cidade(id)
);

CREATE SEQUENCE seq_pessoa_contato INCREMENT 1 START 1;
CREATE TABLE pessoa_contato(
	id int primary key default nextval('seq_pessoa_contato'),
	id_pessoa int not null,
	principal boolean,
	nome varchar(30) not null,
	telefone int default 0,
	email varchar(100) default null,
	constraint fk_pcontato_pessoa foreign key(id_pessoa) references pessoa(id) ON DELETE CASCADE ON UPDATE CASCADE
);