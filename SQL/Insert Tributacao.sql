/*TABELAS DE DADOS DE TRIBUTAÇÃO*/
CREATE TABLE fiscal_origem(
	id int primary key,
	nome varchar(150) not null
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
	nome varchar(150) not null
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
INSERT INTO fiscal_cst(id, nome) VALUES(101,'Tributada pelo Simples Nacional com permissão de crédito');
INSERT INTO fiscal_cst(id, nome) VALUES(102,'Tributada pelo simples nacional sem permissão de crédito');
INSERT INTO fiscal_cst(id, nome) VALUES(103,'Insenção do ICMS no Simples Nacional para a faixa de receita bruta');
INSERT INTO fiscal_cst(id, nome) VALUES(201,'Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por Substituição Tributária');
INSERT INTO fiscal_cst(id, nome) VALUES(202,'Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por Substituição Tributária');
INSERT INTO fiscal_cst(id, nome) VALUES(203,'Isenção do ICMS no Simples Nacional para a faixa de receita bruta e com cobrança do ICMS por Substituição Tributária');
INSERT INTO fiscal_cst(id, nome) VALUES(300,'Imune');
INSERT INTO fiscal_cst(id, nome) VALUES(400,'Não tributada pelo Simples Nacional');
INSERT INTO fiscal_cst(id, nome) VALUES(500,'ICMS cobrado anteriormente por substituição tributária (substituido) ou por antecipação');
INSERT INTO fiscal_cst(id, nome) VALUES(900,'Outros');


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

CREATE TABLE fiscal_modBC(
	id int primary key,
	nome varchar(50) not null unique
);

INSERT INTO fiscal_modBC VALUES (0,'Margem Valor Agregado (%)');
INSERT INTO fiscal_modBC VALUES (1,'Pauta (Valor)');
INSERT INTO fiscal_modBC VALUES (2,'Preço Tabelado Máx.(Valor)');
INSERT INTO fiscal_modBC VALUES (3,'Valor da operação');

CREATE TABLE fiscal_modBC_ST(
	id int primary key,
	nome varchar(50) not null unique
);

INSERT INTO fiscal_modBC_ST VALUES (0,'Preço tabelado ou máximo sugerido');
INSERT INTO fiscal_modBC_ST VALUES (1,'Lista negativa (valor)');
INSERT INTO fiscal_modBC_ST VALUES (2,'Lista positiva (valor)');
INSERT INTO fiscal_modBC_ST VALUES (3,'Lista neutra (valor)');
INSERT INTO fiscal_modBC_ST VALUES (4,'Margem Valor Agregado (%)');
INSERT INTO fiscal_modBC_ST VALUES (5,'Pauta (valor)');

CREATE TABLE fiscal_motDeson_ICMS(
	id primary key,
	nome varchar(100) not null unique
);

INSERT INTO fiscal_motDeson_ICMS VALUES(1,'Táxi');
INSERT INTO fiscal_motDeson_ICMS VALUES(3,'Produtor agropecuário');
INSERT INTO fiscal_motDeson_ICMS VALUES(4,'Frotista/Locadora');
INSERT INTO fiscal_motDeson_ICMS VALUES(5,'Diplomático/Consular');
INSERT INTO fiscal_motDeson_ICMS VALUES(6,'Utilitários e Motocicletas a Amazônia e Áreas de Livre Comércio (Resolução 714/88 e 790/94 - CONTRAN e suas alterações)');
INSERT INTO fiscal_motDeson_ICMS VALUES(7,'SUFRAMA');
INSERT INTO fiscal_motDeson_ICMS VALUES(8,'Venda a Órgãos públicos (NT2011/004)');
INSERT INTO fiscal_motDeson_ICMS VALUES(9,'Outros (NT2011/004)');
INSERT INTO fiscal_motDeson_ICMS VALUES(10,'Deficiente Condutor (Convênio ICMS 38/12)');
INSERT INTO fiscal_motDeson_ICMS VALUES(11,'Deficiente Não Condutor (Convênio ICMS 38/12)');
INSERT INTO fiscal_motDeson_ICMS VALUES(16,'Olimpíadas RIO 2016');