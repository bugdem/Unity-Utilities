using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ClocknestGames.Library.Utils;
using System;

#if UNITY_IOS
using UnityEngine.iOS;
#endif

#if UNITY_ANDROID
using Google.Play.Review;
#endif

namespace ClocknestGames.Game.Core
{
    public class RateUsManager : PersistentSingleton<RateUsManager>
    {
#if UNITY_IOS

        public void Show(Action<bool> onComplete)
        {
            bool isShown = Device.RequestStoreReview();
            onComplete?.Invoke(isShown);
        }

#elif UNITY_ANDROID

        private ReviewManager _reviewManager;
        private PlayReviewInfo _playReviewInfo;

        private void Start()
        {
            _reviewManager = new ReviewManager();
        }

        public void Show(Action<bool> onComplete)
        {
            StartCoroutine(IRequestReviews(onComplete));
        }

        private IEnumerator IRequestReviews(Action<bool> onComplete)
        {
            // Request a ReviewInfo object.
            var requestFlowOperation = _reviewManager.RequestReviewFlow();
            yield return requestFlowOperation;

            if (requestFlowOperation.Error != ReviewErrorCode.NoError)
            {
                Debug.Log("Rate Us - Request review flow failed: " + requestFlowOperation.Error.ToString());
                onComplete?.Invoke(false);

                yield break;
            }

            _playReviewInfo = requestFlowOperation.GetResult();

            // Launch the InApp Review Flow.
            var launchFlowOperation = _reviewManager.LaunchReviewFlow(_playReviewInfo);
            yield return launchFlowOperation;

            // Reset the object.
            _playReviewInfo = null;

            if (launchFlowOperation.Error != ReviewErrorCode.NoError)
            {
                Debug.Log("Rate Us - Launch review flow failed: " + launchFlowOperation.Error.ToString());
                yield break;
            }

            // The flow has finished. The API does not indicate whether the user
            // reviewed or not, or even whether the review dialog was shown.
            // Thus, no matter the result, we continue our app flow.
        }

#else

        public void Show(Action<bool> onComplete)
        {
            onComplete?.Invoke(false);
        }

#endif


    }
}