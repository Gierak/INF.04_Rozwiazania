package com.gierak.kosci

import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import kotlin.random.Random

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

        val kosciObrazy= arrayOf(R.drawable.question,R.drawable.k1,R.drawable.k2,R.drawable.k3,R.drawable.k4,R.drawable.k5,R.drawable.k6)
        val kosciElementy: Array<ImageView> = arrayOf(findViewById(R.id.imageView_kosc1),findViewById(R.id.imageView_kosc2),findViewById(R.id.imageView_kosc3),findViewById(R.id.imageView_kosc4),findViewById(R.id.imageView_kosc5))
        var wynikGry = 0;

        val wynikLosowania = findViewById<TextView>(R.id.textView_wynik_losowania)
        val wynikGryTextView = findViewById<TextView>(R.id.textView_wynik_gry)


        findViewById<Button>(R.id.button_rzuc).setOnClickListener{
            var wylosowane = mutableListOf<Int>()
            for (i in 0..4) {
                val wylosowana = Random.nextInt(1, 7)
                wylosowane.add(wylosowana)
                kosciElementy[i].setImageResource(kosciObrazy[wylosowana])
            }
            Log.d("lb",wylosowane.groupBy { it }.toString())

            var wynik =0;

            wylosowane.groupBy { it }.entries.forEach { entry ->
                if(entry.value.count()>1){
                    wynik += entry.key*entry.value.count()
                }
            }

            wynikLosowania.text = String.format(getString(R.string.wynik_losowania_liczba),wynik);
            wynikGry += wynik
            wynikGryTextView.text = String.format(getString(R.string.wynik_gry_liczba),wynikGry);
        }

        findViewById<Button>(R.id.button_resetuj).setOnClickListener {
            wynikLosowania.text = String.format(getString(R.string.wynik_losowania_liczba),0);
            wynikGry=0;
            wynikGryTextView.text = String.format(getString(R.string.wynik_gry_liczba),0);
            for (i in 0..4) {
                kosciElementy[i].setImageResource(kosciObrazy[0])
            }
        }

    }
}