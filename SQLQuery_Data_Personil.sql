CREATE TABLE [Satker] (
  [id_satker] int identity(1,1) not null,
  [nama_satker] varchar(30),
  [alamat] text,
  [telp ] varchar(15),
  PRIMARY KEY ([id_satker])
);

insert into Satker values('Pusdatin', 'Jl. RS Fatmawati No.1, RT.6/RW.6, Pd. Labu, Kec. Cilandak, Kota Jakarta Selatan, Daerah Khusus Ibukota Jakarta','021-7690009') 

select * from Satker

--insert into personil values ('21120008290392','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','','123','','')
insert into personil values ('21120008290392',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'123',NULL,NULL)
insert into personil values ('526699',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,1,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'123','Staff',getdate())


select * from personil

--select nip_nrp, nama_satker,alamat from personil p, Satker s where p.id_satker=s.id_satker 

update personil set role = 'Staff'  where nip_nrp = '21120008290392' 
update personil set tgl_terdaftar = getdate()  where nip_nrp = '21120008290392' 

select * from Personil where nip_nrp='21120008290392' and password='1234' and role='Staff'

CREATE TABLE [Personil] (
  [nip_nrp] varchar(20) not null,
  [nama_gelar] varchar(30),
  [tempat_lahir] varchar(20),
  [tgl_lahir] date,
  [jns_kelamin] varchar(20),
  [angkatan] varchar(20),
  [sumber_ba_ta] varchar(20),
  [tmt_ba_ta] date,
  [sumber_pa_gol3] varchar(20),
  [tmt_pa_gol3] date,
  [kategori_pegawai] varchar(20),
  [tmt_tni_pns] date,
  [id_satker] int constraint fk_id_satker references Satker(id_satker),
  [tmt_satker] date,
  [agama] varchar(20),
  [status_kawin ] varchar(20),
  [suku_bangsa] varchar(20),
  [alamat_rumah] text,
  [kode_pos] varchar(20),
  [telp_rumah] varchar(20),
  [telp_seluler] varchar(20),
  [email] varchar(20),
  [tinggi_badan] Int,
  [berat_badan] Int,
  [ukuran_sepatu] Int,
  [ukuran_ttp_kepala] Int,
  [gol_darah] char(5),
  [ukuran_baju] char(5),
  [bentuk_muka] varchar(20),
  [jenis_rambut] varchar(20),
  [warna_rambut] varchar(20),
  [ciri_khusus] varchar(30),
  [password] varchar(20),
  [role] varchar(20),
  [tgl_terdaftar] date,
  PRIMARY KEY ([nip_nrp])
);

insert into Riwayat_Keluarga values ('Rayyan','Pria','2018/12/09','Anak','21120008290392')
select * from Riwayat_Keluarga

CREATE TABLE [Riwayat_Keluarga] (
  [id_riw_klg] int identity(1,1) not null,
  [nama_klg] varchar(30),
  [jns_kel] varchar(20),
  [tgl_lhr] date,
  [hub_klg] varchar(30),
  [nip_nrp] varchar(20) constraint fk_nip_nrp references Personil(nip_nrp),
  PRIMARY KEY ([id_riw_klg])
);

--exec sp_help Satker

CREATE TABLE [Kartu_Identitas] (
  [no_kta] varchar(20),
  [no_label_sec] varchar(20),
  [no_karpeg_pns] varchar(20),
  [no_npwp] varchar(20),
  [no_ktp] varchar(20),
  [no_karis_karsu] varchar(20),
  [no_ktpa_asabri] varchar(20),
  [no_kartu_kpi] varchar(20),
  [no_registrasi] varchar(20),
  [no_randis] varchar(20),
  [nip_nrp] varchar(20) constraint fk_nip_nrp2 references Personil(nip_nrp),
  PRIMARY KEY ([no_kta])
);


CREATE TABLE [Riwayat_Penugasan] (
  [id_riw_penugasan] int identity(1,1) not null,
  [kota] varchar(30),
  [negara] varchar(30),
  [tahun] varchar(5),
  [ket] text,
  [nip_nrp] varchar(20) constraint fk_nip_nrp3 references Personil(nip_nrp),
  PRIMARY KEY ([id_riw_penugasan])
);

CREATE TABLE [Kategori_Pendidikan] (
  [id_kategori] int identity(1,1) not null,
  [nama_kategori] varchar(20),
  PRIMARY KEY ([id_kategori])
);

CREATE TABLE [Riwayat_Pendidikan] (
  [id_riw_pend] int identity(1,1) not null,
  [nama_pendidikan] varchar(20),
  [tahun] varchar(5),
  [keterangan] text,
  [nip_nrp] varchar(20) constraint fk_nip_nrp4 references Personil(nip_nrp),
  [id_kategori] int constraint fk_id_kategori references Kategori_Pendidikan(id_kategori) 
);

CREATE TABLE [Riwayat_Tanda_Jasa] (
  [id_riw_tjs] int identity(1,1) not null,
  [nama_tjs] varchar(30),
  [no_skep] varchar(20),
  [tgl_skep] date,
  [nip_nrp] varchar(20) constraint fk_nip_nrp5 references Personil(nip_nrp),
  PRIMARY KEY ([id_riw_tjs])
);


CREATE TABLE [Riwayat_Jabatan] (
  [id_riw_jab] int identity(1,1) not null,
  [kode_jabatan] varchar(30),
  [nama_jabatan] varchar(20),
  [tmt_jabatan] date,
  [nomor_skep ] varchar(20),
  [tgl_skep] date,
  [status_jabatan] varchar(20),
  [nip_nrp] varchar(20) constraint fk_nip_nrp6 references Personil(nip_nrp),
  PRIMARY KEY ([id_riw_jab])
);



CREATE TABLE [Riwayat_Pangkat] (
  [id_riw_pkt] int identity(1,1) not null,
  [nama_pangkat] varchar(30),
  [tmt_pangkat] date,
  [nomor_skep] varchar(20),
  [tgl_skep] date,
  [status_pangkat] varchar(20),
  [nip_nrp] varchar(20) constraint fk_nip_nrp7 references Personil(nip_nrp),
  PRIMARY KEY ([id_riw_pkt])
);

drop table Bahasa
CREATE TABLE [Bahasa] (
  [id_bahasa] int identity(1,1) not null,
  [nama_bahasa] varchar(30),
  [keterangan] text,
  [nip_nrp] varchar(20) constraint fk_nip_nrp8 references Personil(nip_nrp),
  PRIMARY KEY ([id_bahasa])
);



CREATE TABLE [Dokumen] (
  [id_dokumen] int identity(1,1) not null,
  [nama_dokumen] varchar(30),
  [path_dokumen] varchar(40),
  [nip_nrp] varchar(20) constraint fk_nip_nrp9 references Personil(nip_nrp),
  PRIMARY KEY ([id_dokumen])
);