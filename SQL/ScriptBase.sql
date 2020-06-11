

CREATE SEQUENCE seq_usuario INCREMENT 1 START 1;
CREATE TABLE user_usuario(
	id integer primary key default nextval('seq_usuario'),
	login varchar(100) not null unique,
	nome varchar(50) not null,
	senha varchar(100) not null,
	nivel varchar(10)
);

INSERT INTO user_usuario(login, nome, senha, nivel) VALUES('dev','programador','123456','D');

/*Localização geografica*/
CREATE TABLE local_pais(
	id int primary key,
	nome varchar(150) not null
);

CREATE TABLE local_uf(
	id int primary key,
	nome varchar(100) not null,
	id_pais int not null,
	constraint fk_pais foreign key(id_pais) references local_pais(id)
);

CREATE TABLE local_cidade(
	id int primary key,
	nome varchar(100) not null,
	id_uf int not null,
	constraint fk_uf foreign key(id_uf) references local_uf(id)
);

/*--------------------------------------------------------*/

CREATE TABLE sis_crt(
	id int primary key,
	nome varchar(100) not null
);

INSERT INTO sis_crt VALUES (1,'Normal');
INSERT INTO sis_crt VALUES (2,'Simples Nacional');
INSERT INTO sis_crt VALUES (3,'MEI');


CREATE SEQUENCE seq_segmento INCREMENT 1 START 1;
CREATE TABLE sis_segmento(
	id int primary key default nextval('seq_segmento'),
	nome varchar(100) not null
);


/*EMPRESA ------------------------------------------------------------------------*/

CREATE SEQUENCE seq_empresa INCREMENT 1 START 1;
CREATE TABLE empresa(
	id int primary key default nextval('seq_empresa'),
	ativo boolean,
	cnpj varchar(20) not null unique,
	razao_social varchar(200) not null,
	fantasia varchar(100) null,
	matriz boolean,
	filial boolean,
	ie varchar(20) null,
	im varchar(20) null,
	id_crt int not null,/*Regime Tributário*/
	id_segmento int not null,

	cep varchar(10) not null,
	id_pais int not null,
	id_uf int not null,
	id_cidade int not null,
	bairro varchar(50) not null,
	logradouro varchar(100) not null,
	numero int default 0,
	complemento varchar(40) null,

	telefone varchar(14) null,
	celular varchar(14) null,
	contato varchar(50) not null,
	email varchar(150) not null,
	site varchar(150) null,

	dt_cadastro timestamp not null,
	dt_alteracao timestamp,

	constraint fk_pais     foreign key(id_pais)     references local_pais(id),
	constraint fk_uf       foreign key(id_uf)       references local_uf(id),
	constraint fk_cidade   foreign key(id_cidade)   references local_cidade(id),
	constraint fk_crt      foreign key(id_crt)      references sis_crt(id),
	constraint fk_segmento foreign key(id_segmento) references sis_segmento(id)
);

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
	
	cep varchar(10) not null,
	id_pais integer not null,
	id_uf integer not null,
	id_cidade integer not null,
	bairro varchar(50) not null,
	logradouro varchar(100) not null,
	numero integer not null default 0,
	complemento varchar(40) null,
	
	telefone varchar(15),
	celular varchar(15),
	contato varchar(100) not null,
	email varchar(150) null,

	dt_nasc date,
	dt_cadastro timestamp not null,
	dt_alteracao timestamp,

	constraint fk_tipo foreign key(id_tipo) references pessoa_tipo(id),
	constraint fk_pais foreign key(id_pais) references local_pais(id),
	constraint fk_uf foreign key(id_uf) references local_uf(id),
	constraint fk_cidade foreign key(id_cidade) references local_cidade(id)
);

CREATE TABLE pessoa_cliente();
CREATE TABLE pessoa_fornecedor();
CREATE TABLE pessoa_transp();
CREATE TABLE pessoa_funcionario();
CREATE TABLE pessoa_outro();


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


/*CONTROLE DE ESTOQUE ----------------------------------------------------------------*/

CREATE SEQUENCE seq_prod_unidade INCREMENT 1 START 1;
CREATE TABLE produto_unid(
	id int primary key default nextval('seq_prod_unidade'),
	nome varchar(10) not null unique
);

INSERT INTO produto_unid(nome) VALUES ('UN');
INSERT INTO produto_unid(nome) VALUES ('KG');
INSERT INTO produto_unid(nome) VALUES ('CX');
INSERT INTO produto_unid(nome) VALUES ('FD');
INSERT INTO produto_unid(nome) VALUES ('GR');
INSERT INTO produto_unid(nome) VALUES ('MT');
INSERT INTO produto_unid(nome) VALUES ('LT');
INSERT INTO produto_unid(nome) VALUES ('M2');
INSERT INTO produto_unid(nome) VALUES ('M3');

CREATE SEQUENCE seq_prod_tipo INCREMENT 1 START 1;
CREATE TABLE produto_tipo(
	id integer primary key default nextval('seq_prod_tipo'),
	nome varchar(100) not null unique
);

INSERT INTO produto_tipo(nome) VALUES ('Revenda');
INSERT INTO produto_tipo(nome) VALUES ('Matéria-Prima');
INSERT INTO produto_tipo(nome) VALUES ('Uso Interno');
INSERT INTO produto_tipo(nome) VALUES ('Outros');


CREATE SEQUENCE seq_prod_categoria INCREMENT 1 START 1;
CREATE TABLE produto_categ(
	id integer primary key default nextval('seq_prod_categoria'),
	nome varchar(100) not null unique,
	ativo boolean default true
);

CREATE SEQUENCE seq_prod_grupo INCREMENT 1 START 1;
CREATE TABLE produto_grupo(
	id int primary key default nextval('seq_prod_grupo'),
	nome varchar(100) not null,
	id_categ int not null,
	ativo boolean default true,
	constraint fk_categ foreign key(id_categ) references produto_categ(id)
);

CREATE SEQUENCE seq_prod_subgrupo INCREMENT 1 START 1;
CREATE TABLE produto_subgrupo(
	id int primary key default nextval('seq_prod_subgrupo'),
	nome varchar(100) not null,
	id_grupo int not null,
	ativo boolean default true,
	constraint fk_grupo foreign key(id_grupo) references produto_grupo(id)
);


CREATE SEQUENCE seq_produto INCREMENT 1 START 1;
CREATE TABLE produto(
	id int primary key default nextval('seq_produto'),
	ativo boolean default true,
	tp_produto int not null,
	codigo varchar(15) unique,
	nome varchar(50) not null,
	descricao varchar(200) not null,	
	id_unid int not null,
	balanca boolean, 
	marca varchar(40) null,
	fabricante varchar(40) null,
	/*estrutura mercadologica*/
	id_categ int not null,
	id_grupo int not null,
	id_subgrupo int null,
	/*custo e venda*/
	custo decimal(12,2) not null,
	v_com decimal(12,2) default 0, /*comissao*/
	v_com_p decimal(12,2) default 0, /*% comissao*/
	v_desc decimal(12,2) default 0,
	v_desc_p decimal(12,2) default 0,
	v_outros decimal(12,2) default 0,
	v_outros_p decimal(12,2) default 0,
	v_margem decimal(12,2) default 0,
	v_lucro decimal(12,2) default 0,
	venda decimal(12,2) default 0,	
	/*estoque*/
	qtd_min decimal(12,2) null,
	qtd_max decimal(12,2) null,
	tp_un_compra int not null,
	qtd_emb decimal(12,2) not null,
	pbruto decimal(12,3),
	pliquido decimal(12,3),
	altura decimal(12,2),
	largura decimal(12,2),
	comprimento decimal(12,2),
	localizacao varchar(100) null,
	dtcadastro timestamp,
	dtalteracao date,
	imagem varchar(200) null,
	constraint fk_tp_produto   foreign key(tp_produto)        references produto_tipo(id),
	constraint fk_unid         foreign key(id_unid)           references produto_unid(id),
	constraint fk_categ        foreign key(id_categ)          references produto_categ(id),
	constraint fk_grupo        foreign key(id_grupo)          references produto_grupo(id),
	constraint fk_subgrupo     foreign key(id_subgrupo)       references produto_subgrupo(id),
	constraint fk_tp_compra	   foreign key(tp_un_compra)      references produto_unid(id)
);

CREATE TABLE produto_codigos(
	id_produto int primary key,
	codbarra int not null unique,
	constraint fk_produto foreign key(id_produto) references produto(id)
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

CREATE SEQUENCE seq_pedidocompra INCREMENT 1 START 1;
CREATE TABLE pedido_compra(
	id int primary key default nextval('seq_pedidocompra'),
	id_empresa int 	not null,
	id_fornec int not null,
	dt_pedido timestamp not null,
	dt_entrega date,
	id_transp int,
	frete_emit boolean,
	frete_destin boolean,
	sem_frete boolean,
	vl_frente decimal(12,2) null,
	id_pgto int not null
	ped_fornec int,
	vl_total decimal(12,2) not null,
	observacao varchar(150),
	constraint fk_empresa foreign key(id_empresa) references empresa(id),
	constraint fk_fornec foreign key(id_fornec) references pessoa(id),
	constraint fk_transp foreign key(id_transp) references pessoa(id),
	constraint fk_pgto foreign key(id_pgto) references fin_forma_pgto(id)
);

CREATE TABLE pedido_compra_item(
	id_pedido int primary key,
	id_produto int not null,
	id_unid int not null,
	qtd decimal(12,2) not null,
	vl_unit decimal(12,2) not null,
	vl_desc decimal(12,2),
	porc_desc decimal(12,2),
	constraint fk_pedido foreign key(id_pedido) references pedido_compra(id),
	constraint fk_produto foreign key(id_produto) references produto(id),
	constraint fk_unid foreign key(id_unid) references produto_unid(id)
);


CREATE TABLE estoque_tp_nota(
	id int primary key,
	nome varchar(30) not null unique
);

INSERT INTO estoque_tp_nota(id, nome) VALUES(1, 'Eletrônica');
INSERT INTO estoque_tp_nota(id, nome) VALUES(2, 'Manual');
INSERT INTO estoque_tp_nota(id, nome) VALUES(3, 'Produtor Rural');
INSERT INTO estoque_tp_nota(id, nome) VALUES(4, 'Avulsa');
INSERT INTO estoque_tp_nota(id, nome) VALUES(99, 'Outros');


CREATE SEQUENCE seq_entrada INCREMENT 1 START 1;
CREATE TABLE estoque_entrada(
	id int primary key default nextval('seq_entrada'),
	id_empresa int not null,
	id_tpnota int not null, /*Tipo de nota*/
	dh_entrada timestamp not null,
	id_fornec int not null,
	chave_nfe int,
	versao_nfe char(3),
	nat_oper varchar(100) not null, /*natureza da operação*/
	prot_autor varchar(50),
	num_nota int not null,
	serie_nota int not null,
	modelo int,
	emissao timestamp not null,
	sai_ent timestamp,
	/*imposto*/
	bc_icms decimal(12,2),
	vl_icms decimal(12,2),
	icms_deson decimal(12,2),
	v_fcp decimal(12,2),
	fcp_st decimal(12,2),
	fcp_st_ret decimal(12,2),
	v_prod decimal(12,2),
	v_frete decimal(12,2),
	v_seguro decimal(12,2),
	v_desc decimal(12,2),
	v_ipi decimal(12,2),
	ipi_devol decimal(12,2),
	v_pis decimal(12,2),
	v_cofins decimal(12,2),
	v_outro decimal(12,2),
	total_nf decimal(12,2),
	/*transporte*/
	id_transp int,
	mod_frete int not null,
	/*volumes*/
	vol_pbruto decimal(12,2).
	vol_pliquido decimal(12,2),
	anotacao varchar(100),
	fisco varchar(100),
	confirmada boolean, /*confirma que a entrada está correta e não pode ser alterada*/
	dt_confirmada timestamp, /*data de confirmação da entrada*/
	cancelada boolean, /*informa que a entrada está cancelada. Não pode ser alterada nem excluída*/
	dt_cancelada timestamp, /*data em que a entrada foi cancelada*/
	motivo_canc varchar(100) null, /*motivo no qual a entrada foi cancelada*/
	id_pedido int,
	arquivo varchar(400) null, /*localização do arquivo xml*/
	constraint fk_empresa foreign key(id_empresa) references empresa(id),
	constraint fk_tpnota  foreign key(id_tpnota)  references estoque_tp_nota(id),
	constraint fk_fornec  foreign key(id_fornec)  references pessoa(id),
	constraint fk_transp  foreign key(id_transp)  references pessoa(id),
	constraint fk_pedido  foreign key(id_pedido)  references pedido_compra(id)
);

CREATE TABLE estoque_entrada_item(
	id_entrada int not null,
	id_produto int not null,	
	id_cfop int not null,
	id_cst int,
	id_un int not null,
	qtd_un decimal(12,2) not null,
	vl_unit decimal(12,2) not null,
	vl_desconto decimal(12,2),
	vl_outro decimal(12,2),
	bc_icms decimal(12,2),
	vl_icms decimal(12,2),
	vl_ipi decimal(12,2),
	alq_icms decimal(12,2),
	alq_ipi decimal(12,2),
	constraint primary key(id_entrada),
	constraint fk_entrada foreign key(id_entrada) references estoque_entrada(id),
	constraint fk_produto foreign key(id_produto) references produto(id),
	constraint fk_cst     foreign key(id_cst)     references fiscal_cst(id),
	constraint fk_cfop    foreign key(id_cfop)    references fiscal_cfop(id),
	constraint fk_unid    foreign key(id_un)      references produto_unid(id)
);

CREATE SEQUENCE seq_saida INCREMENT 1 START 1;
CREATE TABLE estoque_saida();

CREATE TABLE entoque_saida_item();

/*CONTROLE DE SALDO NO ESTOQUE*/

CREATE SEQUENCE seq_estoque_movimento INCREMENT 1 START 1;
CREATE TABLE estoque_movimento(
	id int primary key	 default nextval('seq_estoque_movimento'),
	id_produto int not null,
	id_empresa int not null,
	data timestamp not null,
	descricao varchar(100) null,/*descricao/origem do movimento do saldo*/
	
	qtd_entrada decimal(12,2) default 0,
	qtd_saida decimal(12,2) default 0,
	saldo_atual decimal(12,2) default 0, /*disponivel para venda*/

	entrada_troca decimal(12,2) default 0,
	saida_troca decimal(12,2) default 0,
	saldo_troca decimal(12,2) default 0,/**/

	entrada_reseva decimal(12,2) default 0,
	saida_reserva decimal(12,2) default 0,
	saldo_reserva decimal(12,2), /*utilizado pedidos/pre-venda/outros*/

	entrada_outros decimal(12,2) default 0,
	saida_outros decimal(12,2) default 0,
	saldo_outros decimal(12,2) default 0,/*utilizado em outros processos*/

	total_estoque decimal(12,2) default 0,
	constraint fk_produto foreign key(id_produto) references produto(id),
	constraint fk_empresa foreign key(id_empresa) references empresa(id)
);












/*CONTROLE FINANCEIRO --------------------------------------------------------*/

CREATE TABLE fin_banco(
	id int primary key,
	codigo int unique,
	nome varchar(100) not null unique,
	ativo boolean default true
);

CREATE SEQUENCE fin_contabancaria INCREMENT 1 START 1;
CREATE TABLE fin_conta_bancaria(
	id int primary key default nextval('fin_contabancaria'),
	id_empresa int not null,
	id_banco int not null,
	agencia int not null,
	conta int not null,
	titular varchar(100) not null,
	constraint fk_empresa foreign key(id_empresa) references empresa(id),
	constraint fk_banco foreign key(id_banco) references fin_banco(id)
);

CREATE TABLE fin_forma_pgto(
	id int primary key,
	nome varchar(40) not null unique
);

INSERT INTO fin_forma_pgto(id, nome) VALUES(1,'Dinheiro');
INSERT INTO fin_forma_pgto(id, nome) VALUES(2,'Cheque');
INSERT INTO fin_forma_pgto(id, nome) VALUES(3,'Cartão de crédito');
INSERT INTO fin_forma_pgto(id, nome) VALUES(4,'Cartão de débito');
INSERT INTO fin_forma_pgto(id, nome) VALUES(5,'Crédito loja');
INSERT INTO fin_forma_pgto(id, nome) VALUES(10,'Vale alimentação');
INSERT INTO fin_forma_pgto(id, nome) VALUES(11,'Vale refeição');
INSERT INTO fin_forma_pgto(id, nome) VALUES(12,'Vale presente');
INSERT INTO fin_forma_pgto(id, nome) VALUES(13,'Vale combustível');
INSERT INTO fin_forma_pgto(id, nome) VALUES(14,'Duplicata mercantil');
INSERT INTO fin_forma_pgto(id, nome) VALUES(15,'Boleto bancário');
INSERT INTO fin_forma_pgto(id, nome) VALUES(90,'Sem pagamento');
INSERT INTO fin_forma_pgto(id, nome) VALUES(99,'Outros');
INSERT INTO fin_forma_pgto(id, nome) VALUES(999,'A Confirmar');


CREATE SEQUENCE seq_plano_conta INCREMENT 1 START 1;
CREATE TABLE fin_plano_conta(
	id int primary key default nextval('seq_plano_conta'),
	codigo varchar(10),
	nome varchar(40) not null,
	entrada boolean,
	saida boolean,
	ativo boolean default true
);

CREATE TABLE fin_situacao(
	id int primary key,
	nome varchar(10) not null unique
);

INSERT INTO fin_situacao(id, nome) VALUES(1, 'Aberto');
INSERT INTO fin_situacao(id, nome) VALUES(2, 'Pago');
INSERT INTO fin_situacao(id, nome) VALUES(3, 'Cancelado');


CREATE SEQUENCE seq_fin_pagar INCREMENT 1 START 1;
CREATE TABLE fin_pagar(
	id int primary key default nextval('seq_fin_pagar'),
	id_empresa int not null,
	id_pessoa int not null,
	descricao varchar(100),
	documento varchar(10) not null,
	id_plano int not null,
	dt_emissao date not null,
	dias int,
	dt_venc date not null,
	valor decimal(12,2) not null,
	desconto decimal(12,2),
	acrescimo decimal(12,2),
	id_forma_pgto int not null,
	id_conta int,/*conta bancaria*/
	dt_pgto date,
	valor_pago decimal(12,2),
	dt_baixa timestamp,
	id_situacao int not null,
	observacao varchar(300),
	/*boleto bancario*/
	id_banco int,
	nosso_numero int, 
	cnab int,
	constraint fk_empresa   foreign key(id_empresa) references empresa(id),
	constraint fk_pessooa   foreign key(id_pessoa)  references pessoa(id),
	constraint fk_plano     foreign key(id_plano)   references fin_plano_conta(id),
	constraint fk_formapgto foreign key(id_plano)   references fin_forma_pgto(id),
	constraint fk_conta     foreign key(id_conta)   references fin_conta_bancaria(id),
	constraint fk_banco     foreign key(id_banco)   references fin_banco(id)
);

CREATE SEQUENCE seq_fin_receber INCREMENT 1 START 1;
CREATE TABLE fin_receber(
	id int primary key default nextval('seq_fin_pagar'),
	id_empresa int not null,
	id_pessoa int not null,
	descricao varchar(100),
	documento varchar(10) not null,
	id_plano int not null,
	dt_emissao date not null,
	dias int,
	dt_venc date not null,
	valor decimal(12,2) not null,
	desconto decimal(12,2),
	acrescimo decimal(12,2),
	id_forma_pgto int not null,
	id_conta int,/*conta bancaria*/
	dt_pgto date,
	valor_pago decimal(12,2),
	dt_baixa timestamp,
	id_situacao int not null,
	observacao varchar(300),
	/*boleto bancario*/
	id_banco int,
	nosso_numero int, 
	cnab int,
	constraint fk_empresa foreign key(id_empresa) references empresa(id),
	constraint fk_pessooa foreign key(id_pessoa) references pessoa(id),
	constraint fk_plano foreign key(id_plano) references fin_plano_conta(id),
	constraint fk_formapgto foreign key(id_plano) references fin_forma_pgto(id),
	constraint fk_conta foreign key(id_conta) references fin_conta_bancaria(id),
	constraint fk_banco foreign key(id_banco) references fin_banco(id)
);


/*------------------------------------------------------------------------*/