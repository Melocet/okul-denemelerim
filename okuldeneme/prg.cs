        {
            try
            {
                OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Z:\766\FormUyg.accdb");
                baglanti.Open();
                string sorgu = string.Format("SELECT * FROM ogrenciler",
                txtbolumkodu.Text, txtbolumadi.Text, txtbolumaciklama.Text);
                OleDbDataAdapter veribagdastirici = new OleDbDataAdapter(sorgu, baglanti);
                DataTable veritablo = new DataTable();
                veribagdastirici.Fill(veritablo);
                dtgrdikvivlistele.DataSource = veritablo;

            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
        }
        
                {
            OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Z:\766\FormUyg.accdb");
            baglanti.Open();
            string sorgu = string.Format("SELECT ogrencino,ogrenciad,ogrencisoyad,ogrenciadres FROM ogrenciler WHERE ogrencino ='{0}'", txtogrno.Text);
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader veriokuma = komut.ExecuteReader();
            while (veriokuma.Read())
            {
                txtogrno.Text = veriokuma.GetValue(0).ToString();
                txtograd.Text = veriokuma.GetValue(1).ToString();
                txtogrsoyad.Text = veriokuma.GetValue(2).ToString();
                txtogrdyeri.Text = veriokuma.GetValue(3).ToString();
            }
            veriokuma.Close();
            baglanti.Close();
        }
        
                {
            OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Z:\766\FormUyg.accdb");
            baglanti.Open();
            string sorgu = "SELECT *FROM bolumler";
            OleDbDataAdapter veribagdastirici = new OleDbDataAdapter(sorgu, baglanti);
            lblkayitsayisi.Text = "Kayit Sayısı " + veribagdastirici.SelectCommand.ExecuteScalar().ToString();
            baglanti.Close();
            DataTable tablo = new DataTable();
            veribagdastirici.Fill(tablo);
            dtgrdikvivlistele.DataSource = tablo;
        }
        
                    if (e.RowIndex >= 0)
            {

                DataGridViewRow satir = this.dtgrdikvivlistele.Rows[e.RowIndex];
                txtogrno.Text = satir.Cells[0].Value.ToString();
                txtograd.Text = satir.Cells[1].Value.ToString();
                txtogrsoyad.Text = satir.Cells[2].Value.ToString();
                txtogrdyeri.Text = satir.Cells[3].Value.ToString();
                txtresimyolu.Text = satir.Cells[4].Value.ToString();

                txtresimyolu.Text = satir.Cells[4].Value.ToString();
                pcrbx.ImageLocation = satir.Cells[4].Value.ToString();
            }
