if not exists (select * from sys.tables where name = 'CATEGORIA')
create table CATEGORIA (
idCategoria int primary key identity(1,1),
cdCategoria varchar(20) not null,
dsCategoria varchar(50) not null,
stAtivo int not null) 

if not exists (select * from sys.tables where name = 'PRODUTO')
create table PRODUTO (
idProduto int primary key identity(1,1),
cdProduto varchar(20) not null,
dsProduto varchar(50) not null,
idCategoria int not null,
constraint FK_PRODUTO_CATEGORIA foreign key (idCategoria) REFERENCES CATEGORIA(idCategoria),
vlPreco numeric(20,6),
qtEstoque numeric(10,3),
stAtivo int not null)
