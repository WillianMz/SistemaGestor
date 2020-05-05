
/*Base de dados --------------------------------------------*/

CREATE TABLE bd_versao();
CREATE TABLE bd_logs();

/*Localização geografica -----------------------------------*/
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

/*--------------------------------------------------------*/
/*rever esta parte*/
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
	id_crt int default 0,/*Regime Tributário*/
	id_segmento int default 0,

	cep varchar(10) not null,
	id_pais int default null,
	id_uf int default null,
	id_cidade int default null,
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

	constraint fk_empresa_pais     foreign key(id_pais)     references local_pais(id)   ON DELETE SET DEFAULT,
	constraint fk_empresa_uf       foreign key(id_uf)       references local_uf(id)     ON DELETE SET DEFAULT,
	constraint fk_empresa_cidade   foreign key(id_cidade)   references local_cidade(id) ON DELETE SET DEFAULT,
	constraint fk_empresa_crt      foreign key(id_crt)      references sis_crt(id) 		ON DELETE SET DEFAULT,
	constraint fk_empresa_segmento foreign key(id_segmento) references sis_segmento(id) ON DELETE SET DEFAULT
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

/*PRODUTOS --------------------------------------------------------------*/

CREATE SEQUENCE seq_prod_unidade INCREMENT 1 START 1;
CREATE TABLE produto_unid(
	id int primary key default nextval('seq_prod_unidade'),
	nome varchar(10) not null unique
);

INSERT INTO produto_unid(nome) VALUES ('UN');
INSERT INTO produto_unid(nome) VALUES ('KG');
INSERT INTO produto_unid(nome) VALUES ('GR');
INSERT INTO produto_unid(nome) VALUES ('MT');
INSERT INTO produto_unid(nome) VALUES ('LT');
INSERT INTO produto_unid(nome) VALUES ('M2');
INSERT INTO produto_unid(nome) VALUES ('M3');

CREATE SEQUENCE seq_prod_embalagem INCREMENT 1 START 1;
CREATE TABLE produto_emb(
	id int primary key default nextval('seq_prod_embalagem'),
	nome varchar(10) not null unique,
	descricao varchar(30) null
);

INSERT INTO produto_unid(nome, descricao) VALUES ('CX', 'Caixa');
INSERT INTO produto_unid(nome, descricao) VALUES ('FD', 'Fardo');
INSERT INTO produto_unid(nome, descricao) VALUES ('DSP', 'Display');
INSERT INTO produto_unid(nome, descricao) VALUES ('PLT', 'Palete');
INSERT INTO produto_unid(nome, descricao) VALUES ('SCL', 'Sacola');

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
	constraint fk_produto_categ foreign key(id_categ) references produto_categ(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE SEQUENCE seq_prod_subgrupo INCREMENT 1 START 1;
CREATE TABLE produto_subgrupo(
	id int primary key default nextval('seq_prod_subgrupo'),
	nome varchar(100) not null,
	id_grupo int not null,
	ativo boolean default true,
	constraint fk_produto_grupo foreign key(id_grupo) references produto_grupo(id) ON DELETE CASCADE ON UPDATE CASCADE
);

/*utilizado para produto iguais mudando apenas o sabor/fragancia/etc.*/
CREATE SEQUENCE seq_prod_semelhante INCREMENT 1 START 1;
CREATE TABLE produto_semelhante(
	id int primary key default nextval('seq_prod_semelhante'),
	nome varchar(100) not null unique,
	ativo boolean default true
);

/*arrumar esta tabela*/
CREATE SEQUENCE seq_produto INCREMENT 1 START 1;
CREATE TABLE produto(
	id int primary key default nextval('seq_produto'),
	codigo     varchar(15) unique,/*principal do produto. Não pode ser repetido*/
	tp_produto int not null,
	ativo      boolean default true,
	balanca    boolean default false,/*caso for true o produto deve ser pesado antes de vender*/ 	
	nome       varchar(50) not null,
	descricao  varchar(200) not null,	
	id_unid    int not null,
	modelo     varchar(40) null,
	marca      varchar(40) null,
	fabricante varchar(40) null,
	cnpj_fab   varchar(20) null, /*cnpj do fabricante do produto*/
	
	/*estrutura mercadologica*/
	id_categ    integer default null,
	id_grupo    integer default null,
	id_subgrupo integer default null,

	/*custo e venda*/
	custo         decimal(12,2) not null,
	comissao      decimal(12,2) default 0, /*comissao*/
	porc_comissao decimal(12,2) default 0, /*% comissao*/
	desconto      decimal(12,2) default 0,
	porc_desconto decimal(12,2) default 0,
	v_outros      decimal(12,2) default 0,
	v_outros_p    decimal(12,2) default 0,
	porc_margem   decimal(12,2) default 0,
	porc_lucro    decimal(12,2) default 0,
	venda         decimal(12,2) default 0,	

	custo decimal(12,2) not null,

	

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
	constraint fk_tp_produto   foreign key(tp_produto)   references produto_tipo(id),
	constraint fk_unid         foreign key(id_unid)      references produto_unid(id),
	constraint fk_categ        foreign key(id_categ)     references produto_categ(id)    ON DELETE SET DEFAULT,
	constraint fk_grupo        foreign key(id_grupo)     references produto_grupo(id)    ON DELETE SET DEFAULT,
	constraint fk_subgrupo     foreign key(id_subgrupo)  references produto_subgrupo(id) ON DELETE SET DEFAULT,
	constraint fk_tp_compra	   foreign key(tp_un_compra) references produto_unid(id)
);

CREATE TABLE produto_codigo(
	id_produto int primary key,
	ativo boolean default true,
	codigo int not null unique,
	constraint fk_produto_cod foreign key(id_produto) references produto(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE produto_detalhes(
	id_produto int primary key,

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

	constraint fk_produto_detalhes foreign key(id_produto) references produto(id) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE produto_hist_preco(
	id_produto int primary key,
	data timestamp not null,
	custo decimal(12,2) not null,
	margem decimal(12,2) not null,
	venda decimal(12,2) not null,
	constraint fk_produto_hist_preco foreign key(id_produto) references produto(id) ON DELETE CASCADE ON UPDATE CASCADE
);

/*CONTROLE DE ESTOQUE ------------------------------------------------------------------------*/






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