

/*ESTRUTURA MERCADOLOGIA INICIAL DO SISTEMA*/
INSERT INTO produto_categ(nome) VALUES ('NÃO INFORMADO');
INSERT INTO produto_categ(nome) VALUES ('MATÉRIA-PRIMA');
INSERT INTO produto_categ(nome) VALUES ('USO INTERNO');

INSERT INTO produto_grupo(nome, id_categ) VALUES('NÃO INFORMADO 1', 1);
INSERT INTO produto_grupo(nome, id_categ) VALUES('NÃO INFORMADO 2', 2);
INSERT INTO produto_grupo(nome, id_categ) VALUES('NÃO INFORMADO 3', 3);

INSERT INTO produto_subgrupo(nome, id_grupo) VALUES('NÃO INFORMADO 11', 1);
INSERT INTO produto_subgrupo(nome, id_grupo) VALUES('NÃO INFORMADO 12', 2);
INSERT INTO produto_subgrupo(nome, id_grupo) VALUES('NÃO INFORMADO 13', 3);

INSERT INTO produto_semelhante(nome) VALUES('TESTE');

