	#pragma strict
	// @script RequireComponent(AudioSource)
	var rayDistance : float = 80.0;
	var tagName : String;
	var numberOfClicks : int = 1;
	var enemyPoint : int = 1;
	var target: Transform;
	var sinal: int = 1;
	var speed: float = 0.01;
	// var audioSource: AudioSource;
	var gameTime : int=20;


	function Start() {
	//	audioSource.Stop();
	//	audioSource = GetComponent.<AudioSource>();
		if (transform.position.x > target.position.x)
			sinal = -1;
		else if (transform.position.x == target.position.x)
			sinal = 0;
	}

	function Update () {
		if(Input.GetMouseButtonDown(0))	
		{
			var hit : RaycastHit;
			var ray : Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, hit, rayDistance))
			{
			
				if(hit.transform.tag == tagName)
				{
					numberOfClicks--;
					transform.localScale.x = transform.localScale.x + 0.31;
					transform.localScale.y = transform.localScale.y + 0.38;


				}
					}
					}
		if(numberOfClicks <= 0)
		{
			var deslocamentoX = Mathf.Abs(transform.position.x - target.position.x);
		//	var deslocamentoY = Mathf.Abs(transform.position.y - target.position.y);
		
			transform.position.x = transform.position.x + (sinal * speed * deslocamentoX);
		//	transform.position.y = transform.position.y - (speed * deslocamentoY);
			//if (!audioSource.isPlaying) {
			//	audioSource.Stop();
			//	audioSource.Play();
			//	InvokeRepeating("CountDown", 1, 1);
			//}	

		}

		if ((Mathf.Abs(transform.position.x - target.position.x) < 0.05)) {
			numberOfClicks = 1;
			Destroy(gameObject);
		}
	}

	function CountDown()
	{
		if(--gameTime <= 0)
		{	
			CancelInvoke("CountDown");
		}
	}

