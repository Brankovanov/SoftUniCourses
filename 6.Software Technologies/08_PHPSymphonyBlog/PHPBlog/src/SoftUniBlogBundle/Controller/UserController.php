<?php

namespace SoftUniBlogBundle\Controller;

use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Entity\User;
use SoftUniBlogBundle\Form\UserType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class UserController extends Controller
{
    /**
     * @Route("/register", name="user_register")
     * @param Request $request
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function register(Request $request)
    {
        $user= new User();
        $form = $this->createForm(UserType::class, $user);
        $form ->handleRequest($request);

        if($form->isSubmitted()){
            $password = $this->get('security.password_encoder')
                ->encodePassword($user, $user->getPassword());

            $user->setPassword($password);
            $em= $this->getDoctrine()->getManager();
            $em->persist($user);
            $em->flush();

            return $this->redirectToRoute('security_login');
        }

        return $this->render('user/register.html.twig',
            ['form'=>$form ->createView()]);
    }

    /**
     * @Route("/logout",name="security_logout")
     * @throws \Exception
     */
    public function logout(){
        throw new \Exception('logout fail');
    }

    /**
     * @Route("/user/profile", name="user_profile")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     */
    public function userProfile(){
        $userId=$this->getUser()->getId();
        $user = $this->getDoctrine()->getRepository(User::class)->find($userId);
        return $this->render("user/profile.html.twig",
        ['user' =>$user]);
    }

    /**
     * @Route ("/user/myArticles",name="user_articles")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     */
    public function myArticles(){
        $articles = $this
            ->getDoctrine()
            ->getRepository(Article::class)
            ->findBy(['authorId'=>$this->getUser()]);

        return $this->render("user/articles.html.twig",
            ['articles'=>$articles]);
    }

}
