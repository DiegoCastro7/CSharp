CREATE TABLE pais(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idpais PRIMARY KEY(id)
);
CREATE TABLE departamento(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    idpaisFk int(11),
    CONSTRAINT Pk_iddepartamento PRIMARY KEY(id),
    CONSTRAINT FK_idpais FOREIGN KEY (idpaisFk) REFERENCES pais(id) 
);
CREATE TABLE ciudad(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    iddepartamentoFk int(11),
    CONSTRAINT Pk_idciudad PRIMARY KEY(id),
    CONSTRAINT FK_iddepartamento FOREIGN KEY (iddepartamentoFk) REFERENCES departamento(id) 
);
CREATE TABLE tipoPersona(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idtipoPersona PRIMARY KEY(id)
);
CREATE TABLE presentacion(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idpresentacion PRIMARY KEY(id)
);
CREATE TABLE rolPersona(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idrolPersona PRIMARY KEY(id)
);
CREATE TABLE formaPago(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_idformaPago PRIMARY KEY(id)
);
CREATE TABLE tipoMovInventario(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoMovInventario PRIMARY KEY(id)
);

CREATE TABLE tipoContacto(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoContacto PRIMARY KEY(id)
);
CREATE TABLE marca (
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_marca PRIMARY KEY(id)
);

CREATE TABLE producto(
    cod VARCHAR(10),
    nombreProd VARCHAR(100),
    idmarca int (11),
    CONSTRAINT Pk_producto PRIMARY KEY (cod),
    CONSTRAINT Fk_idmarca FOREIGN KEY (idmarca) REFERENCES marca(id)
);

CREATE TABLE tipoDocumento(
    id int AUTO_INCREMENT,
    nombre VARCHAR(50),
    CONSTRAINT Pk_tipoDocumento PRIMARY KEY(id)
);

CREATE TABLE persona(
    id VARCHAR (20),
    nombre VARCHAR (50),
    fechaRegistro DATE,
    idDocumento int (11),
    idRolPersona int(11),
    idTipoPersona int (11),
    CONSTRAINT Pk_persona PRIMARY KEY(id),
    CONSTRAINT Fk_idDocumento FOREIGN KEY (idDocumento) REFERENCES tipoDocumento (id),
    CONSTRAINT Fk_idRolPersona FOREIGN KEY (idRolPersona) REFERENCES rolPersona (id),
    CONSTRAINT Fk_idTipoPersona FOREIGN KEY (idTipoPersona) REFERENCES tipoPersona (id)

);
CREATE TABLE ubicacionPersona(
    idDireccion int AUTO_INCREMENT,
    tipoDeVia VARCHAR(50),
    numeroPri smallint,
    letra CHAR(2),
    bis CHAR(10),
    letraSec CHAR(2),
    cardinal CHAR(10),
    numeroSec smallint,
    letraTer CHAR(2),
    numeroTer smallint,
    cardinalSec CHAR(10),
    complemento VARCHAR(50),
    idPersona VARCHAR(20),
    idCiudad int(11),
    CONSTRAINT PK_direccion PRIMARY KEY(idDireccion),
    CONSTRAINT FK_idPersona FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT FK_idCiudad FOREIGN KEy (idCiudad) REFERENCES ciudad(id)
);
CREATE TABLE contactoPersona(
    id int AUTO_INCREMENT,
    idPersona VARCHAR(20),
    idTipoContacto int (11),
    CONSTRAINT PK_contactoPersona PRIMARY KEY(id),
    CONSTRAINT FK_idPersonaContacto FOREIGN KEY (idPersona) REFERENCES persona(id),
    CONSTRAINT FK_idTipoContacto FOREIGN KEY (idTipoContacto) REFERENCES tipoContacto(id)
);
CREATE TABLE inventario(
    id VARCHAR(10),
    nombre VARCHAR(50),
    precio DOUBLE(11, 2),
    stock smallint,
    stockMin smallint,
    stockMax smallint,
    codProducto VARCHAR(10),
    idpresentacion INT(11),
    CONSTRAINT PK_idinventario PRIMARY KEY (id),
    CONSTRAINT FK_CodProducto FOREIGN KEY (codProducto) REFERENCES producto(cod),
    CONSTRAINT FK_idpresentacion FOREIGN KEY (idpresentacion) REFERENCES presentacion(id)
);
CREATE TABLE factura(
    id int AUTO_INCREMENT,
    facturaInicial int,
    facturaFinal int,
    facturaActual int,
    nroResolucion VARCHAR(10),
    CONSTRAINT PK_idfactura PRIMARY KEY (id)
);
CREATE TABLE movimientoInventario(
    id VARCHAR(10),
    idResponsable VARCHAR(20),
    idReceptor VARCHAR(20),
    fechaMovimiento DATE,
    fechaVencimiento DATE,
    idtipoMovInv int(11),
    CONSTRAINT PK_idMovInv PRIMARY KEY(id),
    CONSTRAINT FK_idResponsable FOREIGN KEY (idResponsable) REFERENCES persona(id),
    CONSTRAINT FK_idReceptor FOREIGN KEY (idReceptor) REFERENCES persona(id),
    CONSTRAINT fk_idTipoMovInv FOREIGN KEY (idtipoMovInv) REFERENCES tipoMovInventario(id)
);
CREATE TABLE detalleMovInventario(
    idInventario VARCHAR(10),
    idMovInv VARCHAR(10),
    cantidad TINYINT,
    precio DOUBLE(11, 2),
    CONSTRAINT PK_idinventario_idMovInv PRIMARY KEY (idInventario, idMovInv),
    CONSTRAINT FK_idInventario FOREIGN KEY (idInventario) REFERENCES inventario(id),
    CONSTRAINT FK_idMovInv FOREIGN KEY (idMovInv) REFERENCES movimientoInventario(id)
);
ALTER TABLE movimientoInventario 
ADD idFormaPago INT(11);
ALTER TABLE movimientoInventario
ADD FOREIGN KEY (idFormaPago) REFERENCES formaPago(id);

DML
INSERT (CREAR NUEVOS REGISTROS)
INSERT INTO [TABLA](C1,C2,TC..)ALUES();
VC -> ''
FECHA -> ''
NUMERICOS -> 4345
pais
INSERT INTO pais(nombre) VALUES ('Colombia');
INSERT INTO pais(nombre) VALUES ('Peru'),('Ecuador'),('Panama');
DELETE
UPDATE

DQL
SELECT id,nombre 
FROM pais;

ALTER TABLE pais 
ADD CONSTRAINT UQ_nompais UNIQUE(nombre);

ALTER TABLE departamento 
ADD CONSTRAINT UQ_nomdpto UNIQUE(nombre);

INSERT INTO departamento(nombre,idpaisFk) VALUES ('Amazonas',1),('Antioquia',1),('Arauca',1),('Atlántico',1),('Bolívar',1),('Boyacá',1),('Caldas',1),('Caquetá',1),('Casanare',1),('Cauca',1),('Cesar',1),('Chocó',1),('Córdoba',1),('Cundinamarca',1),('Guainía',1),('Guaviare',1),('Huila',1),('La Guajira',1),('Magdalena',1),('Meta',1),('Nariño',1),('Norte de Santander',1),('Putumayo',1),('Quindío',1),('Risaralda',1),('San Andrés y Providencia',1),('Santander',1),('Sucre',1),('Tolima',1),('Valle del Cauca',1),('Vaupés',1),('Vichada',1);

ALTER TABLE ciudad 
ADD CONSTRAINT UQ_nomciudad UNIQUE(nombre);
ALTER TABLE ciudad
DROP INDEX UQ_nomciudad;

SELECT id,nombre,iddepartamentoFk 
FROM ciudad;

INSERT INTO ciudad(nombre,iddepartamentoFk) VALUES ('Atabapo', 1), ('Atures', 1), ('Autana', 1), ('Manapiare', 1);
INSERT INTO ciudad(nombre,iddepartamentoFk) VALUES ('Abejorral', 2), ('Abriaquí', 2), ('Alejandría', 2), ('Amagá', 2), ('Amalfi', 2), ('Andes', 2), ('Angelópolis', 2), ('Angostura', 2), ('Anorí', 2), ('Anzá', 2), ('Apartadó', 2), ('Arboletes', 2), ('Argelia', 2), ('Armenia', 2), ('Barbosa', 2), ('Bello', 2), ('Belmira', 2), ('Betania', 2), ('Betulia', 2), ('Briceño', 2), ('Buriticá', 2), ('Cáceres', 2), ('Caicedo', 2), ('Caldas', 2), ('Campamento', 2), ('Cañasgordas', 2), ('Caracolí', 2), ('Caramanta', 2), ('Carepa', 2), ('Carolina', 2), ('Caucasia', 2), ('Chigorodó', 2), ('Cisneros', 2), ('Ciudad Bolívar', 2), ('Cocorná', 2), ('Concepción', 2), ('Concordia', 2), ('Copacabana', 2), ('Dabeiba', 2), ('Don Matías', 2), ('Ebéjico', 2), ('El Bagre', 2), ('El Carmen de Viboral', 2), ('El Peñol', 2), ('El Retiro', 2), ('El Santuario', 2), ('Entrerríos', 2), ('Envigado', 2), ('Fredonia', 2), ('Frontino', 2), ('Giraldo', 2), ('Girardota', 2), ('Gómez Plata', 2), ('Granada', 2), ('Guadalupe', 2), ('Guarne', 2), ('Guatapé', 2), ('Heliconia', 2), ('Hispania', 2), ('Itagüí', 2), ('Ituango', 2), ('Jardín', 2), ('Jericó', 2), ('La Ceja', 2), ('La Estrella', 2), ('La Pintada', 2), ('La Unión', 2), ('Liborina', 2), ('Maceo', 2), ('Marinilla', 2), ('Medellín', 2), ('Montebello', 2), ('Murindó', 2), ('Mutatá', 2), ('Nariño', 2), ('Necoclí', 2), ('Nechí', 2), ('Olaya', 2), ('Peque', 2), ('Pueblorrico', 2), ('Puerto Berrío', 2), ('Puerto Nare', 2), ('Puerto Triunfo', 2), ('Remedios', 2), ('Retiro', 2), ('Rionegro', 2), ('Sabanalarga', 2), ('Sabaneta', 2), ('Salgar', 2), ('San Andrés de Cuerquía', 2), ('San Carlos', 2), ('San Francisco', 2), ('San Jerónimo', 2), ('San José de la Montaña', 2), ('San Juan de Urabá', 2), ('San Luis', 2), ('San Pedro', 2), ('San Pedro de Urabá', 2), ('San Rafael', 2), ('San Roque', 2), ('San Vicente', 2), ('Santa Bárbara', 2), ('Santa Fe de Antioquia', 2), ('Santa Rosa de Osos', 2), ('Santo Domingo', 2), ('Segovia', 2), ('Sonsón', 2), ('Sopetrán', 2), ('Támesis', 2), ('Tarazá', 2), ('Tarso', 2), ('Titiribí', 2), ('Toledo', 2), ('Turbo', 2), ('Uramita', 2), ('Urrao', 2), ('Valdivia', 2), ('Valparaíso', 2), ('Vegachí', 2), ('Venecia', 2), ('Vigía del Fuerte', 2), ('Yalí', 2), ('Yarumal', 2), ('Yolombó', 2), ('Yondó', 2), ('Zaragoza', 2);
INSERT INTO ciudad(nombre,iddepartamentoFk) VALUES ('Arauca', 3), ('Arauquita', 3), ('Cravo Norte', 3), ('Fortul', 3), ('Puerto Rondón', 3), ('Saravena', 3), ('Tame', 3);
INSERT INTO ciudad(nombre,iddepartamentoFk) VALUES ('Barranquilla', 4), ('Baranoa', 4), ('Campo de la Cruz', 4), ('Candelaria', 4), ('Galapa', 4), ('Juan de Acosta', 4), ('Luruaco', 4), ('Malambo', 4), ('Manatí', 4), ('Palmar de Varela', 4), ('Piojó', 4), ('Polonuevo', 4), ('Ponedera', 4), ('Puerto Colombia', 4), ('Repelón', 4), ('Sabanagrande', 4), ('Sabanalarga', 4), ('Santa Lucía', 4), ('Santo Tomás', 4), ('Soledad', 4), ('Suán', 4), ('Tubará', 4), ('Usiacurí', 4),('Cartagena', 5), ('Achí', 5), ('Altos del Rosario', 5), ('Arenal', 5), ('Arjona', 5), ('Arroyohondo', 5), ('Barranco de Loba', 5), ('Calamar', 5), ('Cantagallo', 5), ('Cicuco', 5), ('Córdoba', 5), ('Clemencia', 5), ('El Carmen de Bolívar', 5), ('El Guamo', 5), ('El Peñón', 5), ('Hatillo de Loba', 5), ('Magangué', 5), ('Mahates', 5), ('Margarita', 5), ('María la Baja', 5), ('Montecristo', 5), ('Morales', 5), ('Norosí', 5), ('Pinillos', 5), ('Regidor', 5), ('Río Viejo', 5), ('San Cristóbal', 5), ('San Estanislao', 5), ('San Fernando', 5), ('San Jacinto', 5), ('San Jacinto del Cauca', 5), ('San Juan Nepomuceno', 5), ('San Martín de Loba', 5), ('San Pablo', 5), ('Santa Catalina', 5), ('Santa Rosa', 5), ('Santa Rosa del Sur', 5), ('Simití', 5), ('Soplaviento', 5), ('Talaigua Nuevo', 5), ('Tiquisio', 5), ('Turbaco', 5), ('Turbana', 5), ('Villanueva', 5), ('Zambrano', 5),('Tunja', 6), ('Almeida', 6), ('Aquitania', 6), ('Arcabuco', 6), ('Belén', 6), ('Berbeo', 6), ('Beteitiva', 6), ('Boavita', 6), ('Boyacá', 6), ('Briceño', 6), ('Buenavista', 6), ('Busbanzá', 6), ('Caldas', 6), ('Campohermoso', 6), ('Cerinza', 6), ('Chinavita', 6), ('Chiquinquirá', 6), ('Chiscas', 6), ('Chita', 6), ('Chitaraque', 6), ('Chivatá', 6), ('Chivor', 6), ('Ciénega', 6), ('Cómbita', 6), ('Coper', 6), ('Corrales', 6), ('Covarachía', 6), ('Cubará', 6), ('Cucaita', 6), ('Cuítiva', 6), ('Duitama', 6), ('El Cocuy', 6), ('El Espino', 6), ('Firavitoba', 6), ('Floresta', 6), ('Gachantivá', 6), ('Gámeza', 6), ('Garagoa', 6), ('Guacamayas', 6), ('Guateque', 6), ('Guayatá', 6), ('Guican', 6), ('Iza', 6), ('Jenesano', 6), ('Jericó', 6), ('La Capilla', 6), ('La Uvita', 6), ('La Victoria', 6), ('Labranzagrande', 6), ('Macanal', 6), ('Maripí', 6), ('Miraflores', 6), ('Mongua', 6), ('Monguí', 6), ('Moniquirá', 6), ('Motavita', 6), ('Muzo', 6), ('Nobsa', 6), ('Nuevo Colón', 6), ('Oicatá', 6), ('Otanche', 6), ('Pachavita', 6), ('Páez', 6), ('Paipa', 6), ('Pajarito', 6), ('Panqueba', 6), ('Pauna', 6), ('Paya', 6), ('Paz de Río', 6), ('Pesca', 6), ('Pisba', 6), ('Puerto Boyacá', 6), ('Quípama', 6), ('Ramiriquí', 6), ('Ráquira', 6), ('Rondón', 6), ('Saboyá', 6), ('Sáchica', 6), ('Samacá', 6), ('San Eduardo', 6), ('San José de Pare', 6), ('San Luis de Gaceno', 6), ('San Mateo', 6), ('San Miguel de Sema', 6), ('San Pablo de Borbur', 6), ('Santa María', 6), ('Santa Rosa de Viterbo', 6), ('Santa Sofía', 6), ('Santana', 6), ('Sativanorte', 6), ('Sativasur', 6), ('Siachoque', 6), ('Soatá', 6), ('Socha', 6), ('Socotá', 6), ('Sogamoso', 6), ('Somondoco', 6), ('Sora', 6), ('Soracá', 6), ('Sotaquirá', 6), ('Susacón', 6), ('Sutamarchán', 6), ('Sutatenza', 6), ('Tasco', 6), ('Tenza', 6), ('Tibaná', 6), ('Tibasosa', 6), ('Tinjacá', 6), ('Tipacoque', 6), ('Toca', 6), ('Togüí', 6), ('Tópaga', 6), ('Tota', 6), ('Tununguá', 6), ('Turmequé', 6), ('Tuta', 6), ('Tutazá', 6), ('Úmbita', 6), ('Ventaquemada', 6), ('Villa de Leiva', 6), ('Viracachá', 6), ('Zetaquira', 6),('Manizales', 7), ('Aguadas', 7), ('Anserma', 7), ('Aranzazu', 7), ('Belalcázar', 7), ('Chinchiná', 7), ('Filadelfia', 7), ('La Dorada', 7), ('La Merced', 7), ('Manzanares', 7), ('Marmato', 7), ('Marquetalia', 7), ('Marulanda', 7), ('Neira', 7), ('Norcasia', 7), ('Pácora', 7), ('Palestina', 7), ('Pensilvania', 7), ('Riosucio', 7), ('Risaralda', 7), ('Salamina', 7), ('Samaná', 7), ('San José', 7), ('Supía', 7), ('Victoria', 7), ('Villamaría', 7), ('Viterbo', 7),('Florencia', 8), ('Albania', 8), ('Belén de los Andaquíes', 8), ('Cartagena del Chairá', 8), ('Curillo', 8), ('El Doncello', 8), ('El Paujil', 8), ('La Montañita', 8), ('Milán', 8), ('Morelia', 8), ('Puerto Rico', 8), ('San José del Fragua', 8), ('San Vicente del Caguán', 8), ('Solano', 8), ('Solita', 8), ('Valparaíso', 8),('Yopal', 9), ('Aguazul', 9), ('Chámeza', 9), ('Hato Corozal', 9), ('La Salina', 9), ('Maní', 9), ('Monterrey', 9), ('Nunchía', 9), ('Orocué', 9), ('Paz de Ariporo', 9), ('Pore', 9), ('Recetor', 9), ('Sabanalarga', 9), ('Sácama', 9), ('San Luis de Palenque', 9), ('Támara', 9), ('Tauramena', 9), ('Trinidad', 9), ('Villanueva', 9),('Popayán', 10), ('Almaguer', 10), ('Argelia', 10), ('Balboa', 10), ('Bolívar', 10), ('Buenos Aires', 10), ('Cajibío', 10), ('Caldono', 10), ('Caloto', 10), ('Corinto', 10), ('El Tambo', 10), ('Florencia', 10), ('Guachené', 10), ('Guapí', 10), ('Inzá', 10), ('Jambaló', 10), ('La Sierra', 10), ('La Vega', 10), ('López', 10), ('Mercaderes', 10), ('Miranda', 10), ('Morales', 10), ('Padilla', 10), ('Paez', 10), ('Patía', 10), ('Piamonte', 10), ('Piendamó', 10), ('Puerto Tejada', 10), ('Puracé', 10), ('Rosas', 10), ('San Sebastián', 10), ('Santander de Quilichao', 10), ('Santa Rosa', 10), ('Silvia', 10), ('Sotara', 10), ('Suárez', 10), ('Sucre', 10), ('Timbío', 10), ('Timbiquí', 10), ('Toribío', 10), ('Totoró', 10), ('Villa Rica', 10),('Valledupar', 11), ('Aguachica', 11), ('Agustín Codazzi', 11), ('Astrea', 11), ('Becerril', 11), ('Bosconia', 11), ('Chimichagua', 11), ('Chiriguaná', 11), ('Curumaní', 11), ('El Copey', 11), ('El Paso', 11), ('Gamarra', 11), ('González', 11), ('La Gloria', 11), ('La Jagua de Ibirico', 11), ('La Paz', 11), ('Manaure Balcón del Cesar', 11), ('Pailitas', 11), ('Pelaya', 11), ('Pueblo Bello', 11), ('Río de Oro', 11), ('San Alberto', 11), ('San Diego', 11), ('San Martín', 11), ('Tamalameque', 11),('Quibdó', 12), ('Acandí', 12), ('Alto Baudó', 12), ('Atrato', 12), ('Bagadó', 12), ('Bahía Solano', 12), ('Bajo Baudó', 12), ('Bojayá', 12), ('Cértegui', 12), ('Condoto', 12), ('El Carmen de Atrato', 12), ('El Carmen del Darién', 12), ('Istmina', 12), ('Juradó', 12), ('Lloró', 12), ('Medio Atrato', 12), ('Medio Baudó', 12), ('Medio San Juan', 12), ('Nóvita', 12), ('Nuquí', 12), ('Río Iró', 12), ('Río Quito', 12), ('Riosucio', 12), ('Tadó', 12), ('Unguía', 12), ('Unión Panamericana', 12),('Montería', 13), ('Ayapel', 13), ('Buenavista', 13), ('Canalete', 13), ('Cereté', 13), ('Chimá', 13), ('Chinú', 13), ('Ciénaga de Oro', 13), ('Cotorra', 13), ('La Apartada', 13), ('Lorica', 13), ('Los Córdobas', 13), ('Momil', 13), ('Montelíbano', 13), ('Moñitos', 13), ('Planeta Rica', 13), ('Pueblo Nuevo', 13), ('Puerto Escondido', 13), ('Puerto Libertador', 13), ('Purísima de la Concepción', 13), ('Sahagún', 13), ('San Andrés de Sotavento', 13), ('San Antero', 13), ('San Bernardo del Viento', 13), ('San Carlos', 13), ('San Pelayo', 13), ('Tierralta', 13), ('Tuchín', 13), ('Valencia', 13),('Bogotá', 14), ('Agua de Dios', 14), ('Albán', 14), ('Anapoima', 14), ('Anolaima', 14), ('Arbeláez', 14), ('Beltrán', 14), ('Bituima', 14), ('Bojacá', 14), ('Cabrera', 14), ('Cachipay', 14), ('Cajicá', 14), ('Caparrapí', 14), ('Caqueza', 14), ('Carmen de Carupa', 14), ('Chaguaní', 14), ('Chía', 14), ('Chipaque', 14), ('Choachí', 14), ('Chocontá', 14), ('Cogua', 14), ('Cota', 14), ('Cucunubá', 14), ('El Colegio', 14), ('El Peñón', 14), ('El Rosal', 14), ('Facatativá', 14), ('Fomeque', 14), ('Fosca', 14), ('Funza', 14), ('Fúquene', 14), ('Fusagasugá', 14), ('Gachalá', 14), ('Gachancipá', 14), ('Gachetá', 14), ('Gama', 14), ('Girardot', 14), ('Granada', 14), ('Guachetá', 14), ('Guaduas', 14), ('Guasca', 14), ('Guataquí', 14), ('Guatavita', 14), ('Guayabal de Siquima', 14), ('Guayabetal', 14), ('Gutiérrez', 14), ('Jerusalén', 14), ('Junín', 14), ('La Calera', 14), ('La Mesa', 14), ('La Palma', 14), ('La Peña', 14), ('La Vega', 14), ('Lenguazaque', 14), ('Machetá', 14), ('Madrid', 14), ('Manta', 14), ('Medina', 14), ('Mosquera', 14), ('Nariño', 14), ('Nemocón', 14), ('Nilo', 14), ('Nimaima', 14), ('Nocaima', 14), ('Pacho', 14), ('Paime', 14), ('Pandi', 14), ('Paratebueno', 14), ('Pasca', 14), ('Puerto Salgar', 14), ('Pulí', 14), ('Quebradanegra', 14), ('Quetame', 14), ('Quipile', 14), ('Rafael Reyes', 14), ('Ricaurte', 14), ('San Antonio del Tequendama', 14), ('San Bernardo', 14), ('San Cayetano', 14), ('San Francisco', 14), ('San Juan de Río Seco', 14), ('Sasaima', 14), ('Sesquilé', 14), ('Sibaté', 14), ('Silvania', 14), ('Simijaca', 14), ('Soacha', 14), ('Sopó', 14), ('Subachoque', 14), ('Suesca', 14), ('Supatá', 14), ('Susa', 14), ('Sutatausa', 14), ('Tabio', 14), ('Tausa', 14), ('Tena', 14), ('Tenjo', 14), ('Tibacuy', 14), ('Tibirita', 14), ('Tocaima', 14), ('Tocancipá', 14), ('Topaipí', 14), ('Ubalá', 14), ('Ubaque', 14), ('Ubate', 14), ('Une', 14), ('Útica', 14), ('Venecia', 14), ('Vergara', 14), ('Vianí', 14), ('Villagómez', 14), ('Villapinzón', 14), ('Villeta', 14), ('Viotá', 14), ('Yacopí', 14), ('Zipacón', 14), ('Zipaquirá', 14),('Puerto Inírida', 15), ('Barranco Minas', 15), ('Cacahual', 15), ('La Guadalupe', 15), ('Mapiripana', 15), ('Morichal', 15), ('Pana Pana', 15), ('San Felipe', 15),('San José del Guaviare', 16), ('Calamar', 16), ('El Retorno', 16), ('Miraflores', 16),('Neiva', 17), ('Acevedo', 17), ('Agrado', 17), ('Aipe', 17), ('Algeciras', 17), ('Altamira', 17), ('Baraya', 17), ('Campoalegre', 17), ('Colombia', 17), ('Elías', 17), ('Garzón', 17), ('Gigante', 17), ('Guadalupe', 17), ('Hobo', 17), ('Iquira', 17), ('Isnos', 17), ('La Argentina', 17), ('La Plata', 17), ('Nátaga', 17), ('Oporapa', 17), ('Paicol', 17), ('Palermo', 17), ('Palestina', 17), ('Pital', 17), ('Pitalito', 17), ('Rivera', 17), ('Saladoblanco', 17), ('San Agustín', 17), ('Santa María', 17), ('Suaza', 17), ('Tarqui', 17), ('Tello', 17), ('Teruel', 17), ('Tesalia', 17), ('Timaná', 17), ('Villavieja', 17), ('Yaguará', 17),('Riohacha', 18), ('Albania', 18), ('Barrancas', 18), ('Dibulla', 18), ('Distracción', 18), ('El Molino', 18), ('Fonseca', 18), ('Hatonuevo', 18), ('La Jagua del Pilar', 18), ('Maicao', 18), ('Manaure', 18), ('Uribia', 18), ('Urumita', 18), ('Villanueva', 18),('Santa Marta', 19), ('Algarrobo', 19), ('Aracataca', 19), ('Ariguaní', 19), ('Cerro de San Antonio', 19), ('Chivolo', 19), ('Ciénaga', 19), ('Concordia', 19), ('El Banco', 19), ('El Piñón', 19), ('El Retén', 19), ('Fundación', 19), ('Guamal', 19), ('Nueva Granada', 19), ('Pedraza', 19), ('Pijiño del Carmen', 19), ('Pivijay', 19), ('Plato', 19), ('Puebloviejo', 19), ('Remolino', 19), ('Sabanas de San Ángel', 19), ('Salamina', 19), ('San Sebastián de Buenavista', 19), ('San Zenón', 19), ('Santa Ana', 19), ('Santa Bárbara de Pinto', 19), ('Sitionuevo', 19), ('Tenerife', 19), ('Zapayán', 19), ('Zona Bananera', 19),('Villavicencio', 20), ('Acacías', 20), ('Barranca de Upía', 20), ('Cabuyaro', 20), ('Castilla La Nueva', 20), ('Cubarral', 20), ('Cumaral', 20), ('El Calvario', 20), ('El Castillo', 20), ('El Dorado', 20), ('Fuente de Oro', 20), ('Granada', 20), ('Guamal', 20), ('La Macarena', 20), ('La Uribe', 20), ('Lejanías', 20), ('Mapiripán', 20), ('Mesetas', 20), ('Puerto Concordia', 20), ('Puerto Gaitán', 20), ('Puerto López', 20), ('Puerto Lleras', 20), ('Puerto Rico', 20), ('Restrepo', 20), ('San Carlos de Guaroa', 20), ('San Juan de Arama', 20), ('San Juanito', 20), ('San Martín', 20), ('Vistahermosa', 20),('Pasto', 21), ('Albán', 21), ('Aldana', 21), ('Ancuya', 21), ('Arboleda', 21), ('Barbacoas', 21), ('Belén', 21), ('Buesaco', 21), ('Colón', 21), ('Consacá', 21), ('Contadero', 21), ('Córdoba', 21), ('Cuaspud', 21), ('Cumbal', 21), ('Cumbitara', 21), ('El Charco', 21), ('El Peñol', 21), ('El Rosario', 21), ('El Tablón de Gómez', 21), ('El Tambo', 21), ('Funes', 21), ('Guachucal', 21), ('Guaitarilla', 21), ('Gualmatán', 21), ('Iles', 21), ('Imués', 21), ('Ipiales', 21), ('La Cruz', 21), ('La Florida', 21), ('La Llanada', 21), ('La Tola', 21), ('La Unión', 21), ('Leiva', 21), ('Linares', 21), ('Los Andes', 21), ('Magüí', 21), ('Mallama', 21), ('Mosquera', 21), ('Nariño', 21), ('Olaya Herrera', 21), ('Ospina', 21), ('Policarpa', 21), ('Potosí', 21), ('Providencia', 21), ('Puerres', 21), ('Pupiales', 21), ('Ricaurte', 21), ('Roberto Payán', 21), ('Samaniego', 21), ('San Bernardo', 21), ('San Lorenzo', 21), ('San Pablo', 21), ('San Pedro de Cartago', 21), ('Sandoná', 21), ('Santa Bárbara', 21), ('Santacruz', 21), ('Sapuyes', 21), ('Taminango', 21), ('Tangua', 21), ('Tumaco', 21), ('Túquerres', 21), ('Yacuanquer', 21),('Cúcuta', 22), ('Ábrego', 22), ('Arboledas', 22), ('Bochalema', 22), ('Bucarasica', 22), ('Cácota', 22), ('Cachirá', 22), ('Chinácota', 22), ('Chitagá', 22), ('Convención', 22), ('Cucutilla', 22), ('Durania', 22), ('El Carmen', 22), ('El Tarra', 22), ('El Zulia', 22), ('Gramalote', 22), ('Hacarí', 22), ('Herrán', 22), ('La Esperanza', 22), ('La Playa', 22), ('Labateca', 22), ('Los Patios', 22), ('Lourdes', 22), ('Mutiscua', 22), ('Ocaña', 22), ('Pamplona', 22), ('Pamplonita', 22), ('Puerto Santander', 22), ('Ragonvalia', 22), ('Salazar de Las Palmas', 22), ('San Calixto', 22), ('San Cayetano', 22), ('Santiago', 22), ('Santo Domingo de Silos', 22), ('Sardinata', 22), ('Teorama', 22), ('Tibú', 22), ('Toledo', 22), ('Villa Caro', 22), ('Villa del Rosario', 22),('Mocoa', 23), ('Colón', 23), ('Orito', 23), ('Puerto Asís', 23), ('Puerto Caicedo', 23), ('Puerto Guzmán', 23), ('Leguízamo', 23), ('Sibundoy', 23), ('San Francisco', 23), ('San Miguel', 23), ('Santiago', 23), ('Villa Garzón', 23),('Armenia', 24), ('Buenavista', 24), ('Calarcá', 24), ('Circasia', 24), ('Córdoba', 24), ('Filandia', 24), ('Génova', 24), ('La Tebaida', 24), ('Montenegro', 24), ('Pijao', 24), ('Quimbaya', 24), ('Salento', 24),('Pereira', 25), ('Apía', 25), ('Balboa', 25), ('Belén de Umbría', 25), ('Dosquebradas', 25), ('Guática', 25), ('La Celia', 25), ('La Virginia', 25), ('Marsella', 25), ('Mistrató', 25), ('Pueblo Rico', 25), ('Quinchía', 25), ('Santa Rosa de Cabal', 25), ('Santuario', 25),('San Andrés', 26), ('Providencia', 26), ('Santa Catalina', 26),('Bucaramanga', 27), ('Aguada', 27), ('Albania', 27), ('Aratoca', 27), ('Barbosa', 27), ('Barichara', 27), ('Barrancabermeja', 27), ('Betulia', 27), ('Bolívar', 27), ('Cabrera', 27), ('California', 27), ('Capitanejo', 27), ('Carcasí', 27), ('Cepitá', 27), ('Cerrito', 27), ('Charalá', 27), ('Charta', 27), ('Chima', 27), ('Chipatá', 27), ('Cimitarra', 27), ('Concepción', 27), ('Confines', 27), ('Contratación', 27), ('Coromoro', 27), ('Curití', 27), ('El Carmen de Chucurí', 27), ('El Guacamayo', 27), ('El Peñón', 27), ('El Playón', 27), ('Encino', 27), ('Enciso', 27), ('Florián', 27), ('Floridablanca', 27), ('Galan', 27), ('Gambita', 27), ('Girón', 27), ('Guaca', 27), ('Guadalupe', 27), ('Guapotá', 27), ('Guavatá', 27), ('Güepsa', 27), ('Hato', 27), ('Jesús María', 27), ('Jordán', 27), ('La Belleza', 27), ('Landázuri', 27), ('La Paz', 27), ('Lebríja', 27), ('Los Santos', 27), ('Macaravita', 27), ('Málaga', 27), ('Matanza', 27), ('Mogotes', 27), ('Molagavita', 27), ('Ocamonte', 27), ('Oiba', 27), ('Onzaga', 27), ('Palmar', 27), ('Palmas del Socorro', 27), ('Páramo', 27), ('Piedecuesta', 27), ('Pinchote', 27), ('Puente Nacional', 27), ('Puerto Parra', 27), ('Puerto Wilches', 27), ('Rionegro', 27), ('Sabana de Torres', 27), ('San Andrés', 27), ('San Benito', 27), ('San Gil', 27), ('San Joaquín', 27), ('San José de Miranda', 27), ('San Miguel', 27), ('San Vicente de Chucurí', 27), ('Santa Bárbara', 27), ('Santa Helena del Opón', 27), ('Simacota', 27), ('Socorro', 27), ('Suaita', 27), ('Sucre', 27), ('Suratá', 27), ('Tona', 27), ('Valle de San José', 27), ('Vélez', 27), ('Vetas', 27), ('Villanueva', 27), ('Zapatoca', 27),('Sincelejo', 28), ('Buenavista', 28), ('Caimito', 28), ('Colosó', 28), ('Corozal', 28), ('Coveñas', 28), ('El Roble', 28), ('Galeras', 28), ('Guaranda', 28), ('La Unión', 28), ('Los Palmitos', 28), ('Majagual', 28), ('Morroa', 28), ('Ovejas', 28), ('Palmito', 28), ('Sampués', 28), ('San Benito Abad', 28), ('San Juan de Betulia', 28), ('San Marcos', 28), ('San Onofre', 28), ('San Pedro', 28), ('San Luis de Sincé', 28), ('Sucre', 28), ('Santiago de Tolú', 28), ('Tolú Viejo', 28),('Ibagué', 29), ('Alpujarra', 29), ('Alvarado', 29), ('Ambalema', 29), ('Anzoátegui', 29), ('Armero', 29), ('Ataco', 29), ('Cajamarca', 29), ('Carmen de Apicalá', 29), ('Casabianca', 29), ('Chaparral', 29), ('Coello', 29), ('Coyaima', 29), ('Cunday', 29), ('Dolores', 29), ('Espinal', 29), ('Falan', 29), ('Flandes', 29), ('Fresno', 29), ('Guamo', 29), ('Herveo', 29), ('Honda', 29), ('Ibague', 29), ('Icononzo', 29), ('Lérida', 29), ('Líbano', 29), ('Mariquita', 29), ('Melgar', 29), ('Murillo', 29), ('Natagaima', 29), ('Ortega', 29), ('Palocabildo', 29), ('Piedras', 29), ('Planadas', 29), ('Prado', 29), ('Purificación', 29), ('Rioblanco', 29), ('Roncesvalles', 29), ('Rovira', 29), ('Saldaña', 29), ('San Antonio', 29), ('San Luis', 29), ('Santa Isabel', 29), ('Suárez', 29), ('Valle de San Juan', 29), ('Venadillo', 29), ('Villahermosa', 29), ('Villarrica', 29),('Cali', 30), ('Alcalá', 30), ('Andalucía', 30), ('Ansermanuevo', 30), ('Argelia', 30), ('Bolívar', 30), ('Buenaventura', 30), ('Buga', 30), ('Bugalagrande', 30), ('Caicedonia', 30), ('Cali', 30), ('Calima', 30), ('Candelaria', 30), ('Cartago', 30), ('Dagua', 30), ('El Águila', 30), ('El Cairo', 30), ('El Cerrito', 30), ('El Dovio', 30), ('Florida', 30), ('Ginebra', 30), ('Guacarí', 30), ('Jamundí', 30), ('La Cumbre', 30), ('La Unión', 30), ('La Victoria', 30), ('Obando', 30), ('Palmira', 30), ('Pradera', 30), ('Restrepo', 30), ('Riofrío', 30), ('Roldanillo', 30), ('San Pedro', 30), ('Sevilla', 30), ('Toro', 30), ('Trujillo', 30), ('Tuluá', 30), ('Ulloa', 30), ('Versalles', 30), ('Vijes', 30), ('Yotoco', 30), ('Yumbo', 30), ('Zarzal', 30),('Mitú', 31), ('Caruru', 31), ('Pacoa', 31), ('Taraira', 31), ('Papunaua', 31), ('Yavaraté', 31),('Puerto Carreño', 32), ('Cumaribo', 32), ('La Primavera', 32), ('Santa Rosalía', 32);

SELECT INTO C1,C2,C3...
FROM [TABLA]
INNER JOIN TBL1 ON PK = FK

SELECT p.id,p.nombre As NombrePais,d.nombre As NombreDep
FROM pais p
JOIN departamento AS d ON p.id = d.idpaisFk;

SELECT p.id,p.nombre As NombrePais,d.nombre As NombreDep,c.nombre AS NombreCiudad
FROM pais p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk;

CLAUSULAS
- WHERE -> CONDICIONES DE CONSULTA
OPERADORES COMPARACION
=, <, >, >=, <=, <>
OPERADORES DE PATRON 
like '%xxx%'
    '%xxx'
    'xxx%'
OPERADORES LOGICOS
AND, OR, NOT

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE 'MANGA%';

SELECT p.id,p.nombre As NombrePais ,d.nombre As NombreDep,
c.nombre AS NombreCiud
FROM pais AS p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE '%MANGA';

SELECT p.id,p.nombre As NombrePais,d.nombre As NombreDep,c.nombre AS NombreCiudad
FROM pais p
JOIN departamento AS d ON p.id = d.idpaisFk
JOIN ciudad AS c ON d.id = c.iddepartamentoFk
WHERE c.nombre LIKE '%MANGA%';

---------------------------------------------------------

UPDATE 
UPDATE {TBL} SET C=V WHERE CONDICION

INSERT INTO pais(nombre) VALUES ('Benezuela');

UPDATE pais SET nombre='Venezuela' WHERE id=5;

---------------------------------------------------------

DELETE 
DELETE FROM {TBL} WHERE CONDICION

DELETE FROM pais WHERE id=5;
