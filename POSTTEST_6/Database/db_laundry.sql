CREATE DATABASE db_laundry;

USE db_laundry;

CREATE TABLE layanan_laundry (
    id_layanan INT AUTO_INCREMENT PRIMARY KEY,
    nama_layanan VARCHAR(100),
    harga_per_kg INT,
    estimasi_hari INT
);

-- ===============================
-- 1. TAMBAH TABEL JENIS LAYANAN
-- ===============================
CREATE TABLE IF NOT EXISTS jenis_layanan (
    id_jenis INT AUTO_INCREMENT PRIMARY KEY,
    nama_jenis VARCHAR(50) NOT NULL
);

-- ===============================
-- 2. ISI DATA AWAL JENIS
-- ===============================
INSERT INTO jenis_layanan (nama_jenis) VALUES
('Reguler'),
('Express'),
('Premium');

-- ===============================
-- 3. TAMBAH KOLOM BARU KE TABEL LAMA
-- ===============================
ALTER TABLE layanan_laundry
ADD COLUMN id_jenis INT,
ADD COLUMN satuan VARCHAR(20),
ADD COLUMN status VARCHAR(50),
ADD COLUMN deskripsi TEXT;

-- ===============================
-- 4. TAMBAH FOREIGN KEY RELASI
-- ===============================
ALTER TABLE layanan_laundry
ADD CONSTRAINT fk_jenis_laundry
FOREIGN KEY (id_jenis)
REFERENCES jenis_layanan(id_jenis)
ON DELETE CASCADE
ON UPDATE CASCADE;