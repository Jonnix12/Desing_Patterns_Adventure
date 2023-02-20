using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManaager : MonoBehaviour
{
   [FormerlySerializedAs("_tmpText")] [SerializeField] private TMP_Text _scoreText;
   [SerializeField] private TMP_Text _hpText;

   private void Awake()
   {
      Player.OnScoreCanage += UpdateScore;
      Player.OnTakeHit += UpdateHp;
      UpdateScore(0);
   }

   private void OnDestroy()
   {
      Player.OnScoreCanage -= UpdateScore;
      Player.OnTakeHit -= UpdateHp;
   }

   private void UpdateScore(int score)
   {
      _scoreText.text = score.ToString();
   }
   
   private void UpdateHp(int hp)
   {
      _hpText.text = hp.ToString();
   }
}
