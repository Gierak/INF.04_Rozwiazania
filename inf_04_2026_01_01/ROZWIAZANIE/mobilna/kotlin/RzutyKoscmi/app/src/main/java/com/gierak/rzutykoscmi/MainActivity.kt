package com.gierak.rzutykoscmi

import android.os.Bundle
import android.widget.Button
import android.widget.ImageView
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

        val kosci = arrayOf(
            findViewById(R.id.imageView_kosc1),
            findViewById(R.id.imageView_kosc2),
            findViewById(R.id.imageView_kosc3),
            findViewById(R.id.imageView_kosc4),
            findViewById<ImageView>(R.id.imageView_kosc5)
        )

        val kosciObrazy = arrayOf(
            R.drawable.kosc1,
            R.drawable.kosc2,
            R.drawable.kosc3,
            R.drawable.kosc4,
            R.drawable.kosc5,
            R.drawable.kosc6
        )
        val statusKosci = arrayOf(true, true, true, true, true)
        val kosciWyniki = arrayOf(0, 0, 0, 0, 0)


        kosci.forEach { it ->
            it.setOnClickListener {
                if (statusKosci[it.tag.toString().toInt() - 1]) {
                    it.alpha = 0.5f
                    statusKosci[it.tag.toString().toInt() - 1] = false
                } else {
                    it.alpha = 1f
                    statusKosci[it.tag.toString().toInt() - 1] = true
                }

            }
        }

        findViewById<Button>(R.id.button_rzut).setOnClickListener {
            var wynik = 0
            kosci.forEach {
                val nrKosci = it.tag.toString().toInt() - 1
                if (statusKosci[nrKosci]) {
                    kosciWyniki[nrKosci] = (1..6).random()
                    it.setImageResource(kosciObrazy[kosciWyniki[nrKosci] - 1])
                    wynik += kosciWyniki[nrKosci]
                }
            }
            findViewById<TextView>(R.id.textView_wynik).text = wynik.toString()
        }

    }

}


