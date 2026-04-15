package com.gierak.weterynarz

import android.os.Bundle
import android.widget.AdapterView
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.ListView
import android.widget.SeekBar
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        //enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val gatunki = arrayOf("Pies","Kot","Świnka morska")
        var zwierze=1;

        val suwak = findViewById<SeekBar>(R.id.seekBar_lata)
        val listaGatunki = findViewById<ListView>(R.id.listView_gatunek)
        val imieNazwisko = findViewById<EditText>(R.id.editTextText_wlasciciel)
        val cel = findViewById<EditText>(R.id.editTextText2_cel)
        val godzina = findViewById<EditText>(R.id.editTextTime_data)

        listaGatunki.adapter = ArrayAdapter(this, android.R.layout.simple_list_item_1, gatunki)

        listaGatunki.onItemClickListener =
            AdapterView.OnItemClickListener { _, _, position, _ ->
                zwierze = position;
                suwak.max = when(position){
                    0 -> 18
                    1 -> 20
                    2 -> 9
                    else -> {0}
                }
            }

        suwak.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onProgressChanged(
                p0: SeekBar?,
                p1: Int,
                p2: Boolean
            ) {
                findViewById<TextView>(R.id.textView_lata).text = p1.toString()
            }

            override fun onStartTrackingTouch(p0: SeekBar?) {
            }

            override fun onStopTrackingTouch(p0: SeekBar?) {
            }
        })

        findViewById<Button>(R.id.button_ok).setOnClickListener {
            findViewById<TextView>(R.id.textView_wynik).text = "${imieNazwisko.text}, ${gatunki[zwierze]}, ${suwak.progress}, ${cel.text}, ${godzina.text}"
        }

    }
}