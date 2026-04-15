package com.gierak.czcionki

import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.SeekBar
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val cytaty = arrayOf("Dzień dobry", "Good morning", "Buenos dias")
        val poleCytatu = findViewById<TextView>(R.id.textView_cytat)
        val rozmiar = findViewById<TextView>(R.id.textView_rozmiar)
        val suwak = findViewById<SeekBar>(R.id.seekBar_suwak)
        var aktualnaPozycja = 0

        findViewById<Button>(R.id.button_nastepny).setOnClickListener {
            if (aktualnaPozycja == cytaty.size - 1) {
                aktualnaPozycja = 0
            } else {
                aktualnaPozycja++
            }
            poleCytatu.text = cytaty[aktualnaPozycja]
        }

        suwak.setOnSeekBarChangeListener(object : SeekBar.OnSeekBarChangeListener {
            override fun onProgressChanged(
                p0: SeekBar?, p1: Int, p2: Boolean
            ) {
                rozmiar.text = getString(R.string.rozmiar_wartosc, p1)
                poleCytatu.textSize = p1.toFloat()
            }

            override fun onStartTrackingTouch(p0: SeekBar?) {

            }

            override fun onStopTrackingTouch(p0: SeekBar?) {

            }
        })

    }
}