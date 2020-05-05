/*TABELAS DE DADOS DE TRIBUTAÇÃO --------------------------------------------------*/
CREATE TABLE fiscal_origem(
	id int primary key,
	nome varchar(200) not null
);

INSERT INTO fiscal_origem(id, nome) VALUES (0,'Nacional, exceto as indicadas nos códigos 3 a 5');
INSERT INTO fiscal_origem(id, nome) VALUES (1,'Estrangeira - Importação direta, exceto a indicada no código 6');
INSERT INTO fiscal_origem(id, nome) VALUES (2,'Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7');
INSERT INTO fiscal_origem(id, nome) VALUES (3,'Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40%');
INSERT INTO fiscal_origem(id, nome) VALUES (4,'Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam o Decreto-Lei nº 288/67 e as Leis nºs 8.248/91,
8.387/91, 10.176/01 e 11.484/07');
INSERT INTO fiscal_origem(id, nome) VALUES (5,'Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40%');
INSERT INTO fiscal_origem(id, nome) VALUES (6,'Estrangeira - Importação direta, sem similar nacional, constante em lista de Resolução CAMEX');
INSERT INTO fiscal_origem(id, nome) VALUES (7,'Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista de Resolução CAMEX');

CREATE TABLE fiscal_cst(
	id int primary key,
	nome varchar(150) not null,
	simples boolean default false
);

INSERT INTO fiscal_cst(id, nome) VALUES(00,'Tributada integralmente');
INSERT INTO fiscal_cst(id, nome) VALUES(10,'Tributada e com cobrança do ICMS por substituição tributaria');
INSERT INTO fiscal_cst(id, nome) VALUES(20,'Com redução da Base de cálculo');
INSERT INTO fiscal_cst(id, nome) VALUES(30,'Isenta / não tributada e com cobrança do ICMS por substituição tributaria');
INSERT INTO fiscal_cst(id, nome) VALUES(40,'Isenta');
INSERT INTO fiscal_cst(id, nome) VALUES(41,'Não tributada');
INSERT INTO fiscal_cst(id, nome) VALUES(50,'Com suspensão');
INSERT INTO fiscal_cst(id, nome) VALUES(51,'Com diferimento');
INSERT INTO fiscal_cst(id, nome) VALUES(60,'ICMS cobrado anteriormente por substituição tributaria');
INSERT INTO fiscal_cst(id, nome) VALUES(70,'Com redução da Base de cálculo do ICMS por substituição tributaria');
INSERT INTO fiscal_cst(id, nome) VALUES(90,'Outras');
INSERT INTO fiscal_cst(id, nome, simples) VALUES(101,'Tributada pelo Simples Nacional com permissão de crédito',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(102,'Tributada pelo simples nacional sem permissão de crédito',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(103,'Insenção do ICMS no Simples Nacional para a faixa de receita bruta',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(201,'Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(202,'Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(203,'Isenção do ICMS no Simples Nacional para a faixa de receita bruta e com cobrança do ICMS por Substituição Tributária',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(300,'Imune',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(400,'Não tributada pelo Simples Nacional',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(500,'ICMS cobrado anteriormente por substituição tributária (substituido) ou por antecipação',true);
INSERT INTO fiscal_cst(id, nome, simples) VALUES(900,'Outros',true);


CREATE TABLE fiscal_cfop(
	id int primary key,
	descricao varchar(100) not null,
	entrada boolean,
	saida boolean,
	calcula_icms boolean,
	calcula_ipi boolean,
	baixa_estoque boolean,
	dentro_uf boolean,
	reducao_icms decimal(12,2),
	outros varchar(50)
);

CREATE TABLE fiscal_ncm(
	id_ncm int primary key,
	cest int not null,
	nome varchar(200) not null,
	id_segmento int not null,
	prod_escala_relevante boolean,
	prod_escala_nao_relevante boolean,
	desativado boolean,
	constraint fk_segmento foreign key(id_segmento) references sis_segmento(id)
);



CREATE TABLE produto_tributacao(
	id_produto int not null,
	id_origem int not null,
	id_ncm int not null,
	cest int,
	id_cfop_dentro_uf int,	
	id_cfop_fora_uf int,
	id_sit_trib int not null,
	icms decimal(12,2),
	ipi decimal(12,2),
	pis_cofins decimal(12,2),
	outros_impostos decimal(12,2),
	constraint fk_origem       foreign key(id_origem)         references fiscal_origem(id),
	constraint fk_ncm          foreign key(id_ncm)            references fiscal_ncm(id_ncm),
	constraint fk_cfop_uf      foreign key(id_cfop_dentro_uf) references fiscal_cfop(id),
	constraint fk_cfop_fora_uf foreign key(id_cfop_fora_uf)   references fiscal_cfop(id),
	constraint fk_sit_trib     foreign key(id_sit_trib)       references fiscal_sit_tributaria(id)
);
