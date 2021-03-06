using UnityEngine;
using System.Collections;

public class desativaItens2 : MonoBehaviour {
	
	public GameObject dropurso;
	public GameObject Seringa;
	public GameObject garrote;
	public dropper_Estagio2 ReferenciaDropper;

	public void OnMouseDown(){

		if (dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual == 7) {
			//PROCEDIMENTO DE REMOVER SERINGA APÓS ANIMAÇÃO DE MEDICAMENTO!
			Seringa.SetActive (false);
			dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual++;
			ReferenciaDropper.RetornaPontuacaoPorEtapa ();
			dropurso.GetComponent<dropper_Estagio2> ().ReferenciaDialogos.ReferenciaParaPularDeDialogo();
		}

		if(dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual == 6){
			Seringa.GetComponent<Animator> ().SetBool ("Medicando", true);
			//PAREI AQUI
			dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual++;
			dropurso.GetComponent<dropper_Estagio2> ().ReferenciaDialogos.ReferenciaParaPularDeDialogo();
		}
		
		if (dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual == 5) {
			if(dropurso.GetComponent<dropper_Estagio2>().SpriteGarroteVerde){
				ReferenciaDropper.SpriteGarroteVerde.enabled = true;
				ReferenciaDropper.SpriteGarroteAzul.enabled = true;
			}
			garrote.GetComponent<SkinnedMeshRenderer> ().enabled = false;
			dropurso.GetComponent<dropper_Estagio2> ().procedimentoAtual++;
			ReferenciaDropper.RetornaPontuacaoPorEtapa ();
			dropurso.GetComponent<dropper_Estagio2> ().ReferenciaDialogos.ReferenciaParaPularDeDialogo();
			Seringa.GetComponent<BoxCollider>().enabled = true;
			ReferenciaDropper.animacao.SetTrigger("zoom_out");
		}

	}
}