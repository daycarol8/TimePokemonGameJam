using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip passosPlayer, somBigorna, somPorta, somPulo, somBotao, somChave, somTiro, somMorri;
    static AudioSource audioSrc;
    void Start() {
        passosPlayer = Resources.Load<AudioClip>("passos");
        somBigorna = Resources.Load<AudioClip>("bigorna");
        somPorta = Resources.Load<AudioClip>("porta");
        somPulo = Resources.Load<AudioClip>("pulo");
        somBotao = Resources.Load<AudioClip>("botao");
        somChave = Resources.Load<AudioClip>("chave");
        somTiro = Resources.Load<AudioClip>("tiro");
        somMorri = Resources.Load<AudioClip>("morri");
        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string som) {
        switch (som) {
            case "passos":
                audioSrc.PlayOneShot(passosPlayer);
                break;
            case "bigorna":
                audioSrc.PlayOneShot(somBigorna);
                break;
            case "porta":
                audioSrc.PlayOneShot(somPorta);
                break;
            case "pulo":
                audioSrc.PlayOneShot(somPulo);
                break;
            case "botao":
                audioSrc.PlayOneShot(somBotao);
                break;
            case "chave":
                audioSrc.PlayOneShot(somChave);
                break;
            case "tiro":
                audioSrc.PlayOneShot(somTiro);
                break;
            case "morri":
                audioSrc.PlayOneShot(somMorri);
                break;

        }
    }
}
