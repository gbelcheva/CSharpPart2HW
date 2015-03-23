


<!DOCTYPE html>
<html lang="en" class="">
  <head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb# object: http://ogp.me/ns/object# article: http://ogp.me/ns/article# profile: http://ogp.me/ns/profile#">
    <meta charset='utf-8'>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    
    
    <title>CSharp-Part-1/README.md at master · TelerikAcademy/CSharp-Part-1</title>
    <link rel="search" type="application/opensearchdescription+xml" href="/opensearch.xml" title="GitHub">
    <link rel="fluid-icon" href="https://github.com/fluidicon.png" title="GitHub">
    <link rel="apple-touch-icon" sizes="57x57" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="114x114" href="/apple-touch-icon-114.png">
    <link rel="apple-touch-icon" sizes="72x72" href="/apple-touch-icon-144.png">
    <link rel="apple-touch-icon" sizes="144x144" href="/apple-touch-icon-144.png">
    <meta property="fb:app_id" content="1401488693436528">

      <meta content="@github" name="twitter:site" /><meta content="summary" name="twitter:card" /><meta content="TelerikAcademy/CSharp-Part-1" name="twitter:title" /><meta content="CSharp-Part-1 - Repository for the course &amp;quot;C# part 1&amp;quot;" name="twitter:description" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" name="twitter:image:src" />
      <meta content="GitHub" property="og:site_name" /><meta content="object" property="og:type" /><meta content="https://avatars2.githubusercontent.com/u/1455020?v=3&amp;s=400" property="og:image" /><meta content="TelerikAcademy/CSharp-Part-1" property="og:title" /><meta content="https://github.com/TelerikAcademy/CSharp-Part-1" property="og:url" /><meta content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;" property="og:description" />
      <meta name="browser-stats-url" content="/_stats">
    <link rel="assets" href="https://assets-cdn.github.com/">
    <link rel="xhr-socket" href="/_sockets">
    <meta name="pjax-timeout" content="1000">
    <link rel="sudo-modal" href="/sessions/sudo_modal">

    <meta name="msapplication-TileImage" content="/windows-tile.png">
    <meta name="msapplication-TileColor" content="#ffffff">
    <meta name="selected-link" value="repo_source" data-pjax-transient>
      <meta name="google-analytics" content="UA-3769691-2">

    <meta content="collector.githubapp.com" name="octolytics-host" /><meta content="collector-cdn.github.com" name="octolytics-script-host" /><meta content="github" name="octolytics-app-id" /><meta content="550B9B1B:666E:5A82950:550F5916" name="octolytics-dimension-request_id" /><meta content="10212766" name="octolytics-actor-id" /><meta content="gbelcheva" name="octolytics-actor-login" /><meta content="30554f60b67ae38abc6b6ec5fcb79a6e3dd028cd7a79dc162d701ed1df57a1c7" name="octolytics-actor-hash" />
    
    <meta content="Rails, view, blob#show" name="analytics-event" />

    
    <link rel="icon" type="image/x-icon" href="https://assets-cdn.github.com/favicon.ico">


    <meta content="authenticity_token" name="csrf-param" />
<meta content="9gTPwC80tLjqYDaA826EPmMTrhUsSsgcXx+5OBFPYeF7QDH3NtwRuQjHH3s/6O5N25bl0+Hmufd1NN43SIqIjw==" name="csrf-token" />

    <link href="https://assets-cdn.github.com/assets/github-099e0ecc2851c8aca89ef6dafa191df3b0f2a2c8ad34e134c5473ca1ba0a59b2.css" media="all" rel="stylesheet" />
    <link href="https://assets-cdn.github.com/assets/github2-1171344316fc088255ee2a06c271d14240f1a4e06985fe9e897762947872e858.css" media="all" rel="stylesheet" />
    
    


    <meta http-equiv="x-pjax-version" content="c0f32272c66bfb10ed7d46b7c88c6299">

      
  <meta name="description" content="CSharp-Part-1 - Repository for the course &quot;C# part 1&quot;">
  <meta name="go-import" content="github.com/TelerikAcademy/CSharp-Part-1 git https://github.com/TelerikAcademy/CSharp-Part-1.git">

  <meta content="1455020" name="octolytics-dimension-user_id" /><meta content="TelerikAcademy" name="octolytics-dimension-user_login" /><meta content="28328936" name="octolytics-dimension-repository_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_nwo" /><meta content="true" name="octolytics-dimension-repository_public" /><meta content="false" name="octolytics-dimension-repository_is_fork" /><meta content="28328936" name="octolytics-dimension-repository_network_root_id" /><meta content="TelerikAcademy/CSharp-Part-1" name="octolytics-dimension-repository_network_root_nwo" />
  <link href="https://github.com/TelerikAcademy/CSharp-Part-1/commits/master.atom" rel="alternate" title="Recent Commits to CSharp-Part-1:master" type="application/atom+xml">

  </head>


  <body class="logged_in  env-production windows vis-public page-blob">
    <a href="#start-of-content" tabindex="1" class="accessibility-aid js-skip-to-content">Skip to content</a>
    <div class="wrapper">
      
      
      


        <div class="header header-logged-in true" role="banner">
  <div class="container clearfix">

    <a class="header-logo-invertocat" href="https://github.com/" data-hotkey="g d" aria-label="Homepage" data-ga-click="Header, go to dashboard, icon:logo">
  <span class="mega-octicon octicon-mark-github"></span>
</a>


      <div class="site-search repo-scope js-site-search" role="search">
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/search" class="js-site-search-form" data-global-search-url="/search" data-repo-search-url="/TelerikAcademy/CSharp-Part-1/search" method="get"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /></div>
  <input type="text"
    class="js-site-search-field is-clearable"
    data-hotkey="s"
    name="q"
    placeholder="Search"
    data-global-scope-placeholder="Search GitHub"
    data-repo-scope-placeholder="Search"
    tabindex="1"
    autocapitalize="off">
  <div class="scope-badge">This repository</div>
</form>
      </div>
      <ul class="header-nav left" role="navigation">
        <li class="header-nav-item explore">
          <a class="header-nav-link" href="/explore" data-ga-click="Header, go to explore, text:explore">Explore</a>
        </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="https://gist.github.com" data-ga-click="Header, go to gist, text:gist">Gist</a>
          </li>
          <li class="header-nav-item">
            <a class="header-nav-link" href="/blog" data-ga-click="Header, go to blog, text:blog">Blog</a>
          </li>
        <li class="header-nav-item">
          <a class="header-nav-link" href="https://help.github.com" data-ga-click="Header, go to help, text:help">Help</a>
        </li>
      </ul>

    
<ul class="header-nav user-nav right" id="user-links">
  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link name" href="/gbelcheva" data-ga-click="Header, go to profile, text:username">
      <img alt="@gbelcheva" class="avatar" data-user="10212766" height="20" src="https://avatars2.githubusercontent.com/u/10212766?v=3&amp;s=40" width="20" />
      <span class="css-truncate">
        <span class="css-truncate-target">gbelcheva</span>
      </span>
    </a>
  </li>

  <li class="header-nav-item dropdown js-menu-container">
    <a class="header-nav-link js-menu-target tooltipped tooltipped-s" href="#" aria-label="Create new..." data-ga-click="Header, create new, icon:add">
      <span class="octicon octicon-plus"></span>
      <span class="dropdown-caret"></span>
    </a>

    <div class="dropdown-menu-content js-menu-content">
      
<ul class="dropdown-menu">
  <li>
    <a href="/new" data-ga-click="Header, create new repository, icon:repo"><span class="octicon octicon-repo"></span> New repository</a>
  </li>
  <li>
    <a href="/organizations/new" data-ga-click="Header, create new organization, icon:organization"><span class="octicon octicon-organization"></span> New organization</a>
  </li>


    <li class="dropdown-divider"></li>
    <li class="dropdown-header">
      <span title="TelerikAcademy/CSharp-Part-1">This repository</span>
    </li>
      <li>
        <a href="/TelerikAcademy/CSharp-Part-1/issues/new" data-ga-click="Header, create new issue, icon:issue"><span class="octicon octicon-issue-opened"></span> New issue</a>
      </li>
</ul>

    </div>
  </li>

  <li class="header-nav-item">
        <a href="/notifications" aria-label="You have no unread notifications" class="header-nav-link notification-indicator tooltipped tooltipped-s" data-ga-click="Header, go to notifications, icon:read" data-hotkey="g n">
        <span class="mail-status all-read"></span>
        <span class="octicon octicon-inbox"></span>
</a>
  </li>

  <li class="header-nav-item">
    <a class="header-nav-link tooltipped tooltipped-s" href="/settings/profile" id="account_settings" aria-label="Settings" data-ga-click="Header, go to settings, icon:settings">
      <span class="octicon octicon-gear"></span>
    </a>
  </li>

  <li class="header-nav-item">
    <form accept-charset="UTF-8" action="/logout" class="logout-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="NreibPgnBt3ReI5XB8Zo2rEDZYZBuRMrITlDieMb1/CHYEq/h2NfyqZ9r41jlMg1NqBuI3VJBFr29EU/hUPiZA==" /></div>
      <button class="header-nav-link sign-out-button tooltipped tooltipped-s" aria-label="Sign out" data-ga-click="Header, sign out, icon:logout">
        <span class="octicon octicon-sign-out"></span>
      </button>
</form>  </li>

</ul>


    
  </div>
</div>

        

        


      <div id="start-of-content" class="accessibility-aid"></div>
          <div class="site" itemscope itemtype="http://schema.org/WebPage">
    <div id="js-flash-container">
      
    </div>
    <div class="pagehead repohead instapaper_ignore readability-menu">
      <div class="container">
        
<ul class="pagehead-actions">

  <li>
      <form accept-charset="UTF-8" action="/notifications/subscribe" class="js-social-container" data-autosubmit="true" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="pSBo82kw5T1SCgo8Rm+2uUxZkIeiPhl1Z6w38oZ0frcXJ7UpZLTOO32c/ArI3HJIYE5494wP8sK5QwHOzlnY5Q==" /></div>    <input id="repository_id" name="repository_id" type="hidden" value="28328936" />

      <div class="select-menu js-menu-container js-select-menu">
        <a href="/TelerikAcademy/CSharp-Part-1/subscription"
          class="btn btn-sm btn-with-count select-menu-button js-menu-target" role="button" tabindex="0" aria-haspopup="true"
          data-ga-click="Repository, click Watch settings, action:blob#show">
          <span class="js-select-button">
            <span class="octicon octicon-eye"></span>
            Watch
          </span>
        </a>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/watchers">
          20
        </a>

        <div class="select-menu-modal-holder">
          <div class="select-menu-modal subscription-menu-modal js-menu-content" aria-hidden="true">
            <div class="select-menu-header">
              <span class="select-menu-title">Notifications</span>
              <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
            </div>

            <div class="select-menu-list js-navigation-container" role="menu">

              <div class="select-menu-item js-navigation-item selected" role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input checked="checked" id="do_included" name="do" type="radio" value="included" />
                  <span class="select-menu-item-heading">Not watching</span>
                  <span class="description">Be notified when participating or @mentioned.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Watch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_subscribed" name="do" type="radio" value="subscribed" />
                  <span class="select-menu-item-heading">Watching</span>
                  <span class="description">Be notified of all conversations.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-eye"></span>
                    Unwatch
                  </span>
                </div>
              </div>

              <div class="select-menu-item js-navigation-item " role="menuitem" tabindex="0">
                <span class="select-menu-item-icon octicon octicon-check"></span>
                <div class="select-menu-item-text">
                  <input id="do_ignore" name="do" type="radio" value="ignore" />
                  <span class="select-menu-item-heading">Ignoring</span>
                  <span class="description">Never be notified.</span>
                  <span class="js-select-button-text hidden-select-button-text">
                    <span class="octicon octicon-mute"></span>
                    Stop ignoring
                  </span>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
</form>
  </li>

  <li>
    
  <div class="js-toggler-container js-social-container starring-container ">

    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/unstar" class="js-toggler-form starred js-unstar-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="VZXUrDanvln6N7itjxYlSX/lJT8+LMcHZC0KdmkcL5hWHVPRPvI12WeGkYQbkDszDDgNNWP5KKviJTp8wzQjVg==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Unstar this repository" title="Unstar TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click unstar button, action:blob#show; text:Unstar">
        <span class="octicon octicon-star"></span>
        Unstar
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>
    <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/star" class="js-toggler-form unstarred js-star-button" data-remote="true" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="ilOZmfOJFqCeKhN67jZSK6P61YTb6CNCigzhRb3Znvl9908igbf572j03YIceb9Qo1WAv8Mk3TLIQp81/3A6Ug==" /></div>
      <button
        class="btn btn-sm btn-with-count js-toggler-target"
        aria-label="Star this repository" title="Star TelerikAcademy/CSharp-Part-1"
        data-ga-click="Repository, click star button, action:blob#show; text:Star">
        <span class="octicon octicon-star"></span>
        Star
      </button>
        <a class="social-count js-social-count" href="/TelerikAcademy/CSharp-Part-1/stargazers">
          12
        </a>
</form>  </div>

  </li>

        <li>
          <a href="#fork-destination-box" class="btn btn-sm btn-with-count"
              title="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              aria-label="Fork your own copy of TelerikAcademy/CSharp-Part-1 to your account"
              rel="facebox"
              data-ga-click="Repository, show fork modal, action:blob#show; text:Fork">
            <span class="octicon octicon-repo-forked"></span>
            Fork
          </a>
          <a href="/TelerikAcademy/CSharp-Part-1/network" class="social-count">37</a>

          <div id="fork-destination-box" style="display: none;">
            <h2 class="facebox-header">Where should we fork this repository?</h2>
            <include-fragment src=""
                class="js-fork-select-fragment fork-select-fragment"
                data-url="/TelerikAcademy/CSharp-Part-1/fork?fragment=1">
              <img alt="Loading" height="64" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-128-338974454bb5c32803e82f601beb051d373744b024fe8742a76009700fd7e033.gif" width="64" />
            </include-fragment>
          </div>
        </li>

</ul>

        <h1 itemscope itemtype="http://data-vocabulary.org/Breadcrumb" class="entry-title public">
          <span class="mega-octicon octicon-repo"></span>
          <span class="author"><a href="/TelerikAcademy" class="url fn" itemprop="url" rel="author"><span itemprop="title">TelerikAcademy</span></a></span><!--
       --><span class="path-divider">/</span><!--
       --><strong><a href="/TelerikAcademy/CSharp-Part-1" class="js-current-repository" data-pjax="#js-repo-pjax-container">CSharp-Part-1</a></strong>

          <span class="page-context-loader">
            <img alt="" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
          </span>

        </h1>
      </div><!-- /.container -->
    </div><!-- /.repohead -->

    <div class="container">
      <div class="repository-with-sidebar repo-container new-discussion-timeline  ">
        <div class="repository-sidebar clearfix">
            
<nav class="sunken-menu repo-nav js-repo-nav js-sidenav-container-pjax js-octicon-loaders"
     role="navigation"
     data-pjax="#js-repo-pjax-container"
     data-issue-count-url="/TelerikAcademy/CSharp-Part-1/issues/counts">
  <ul class="sunken-menu-group">
    <li class="tooltipped tooltipped-w" aria-label="Code">
      <a href="/TelerikAcademy/CSharp-Part-1" aria-label="Code" class="selected js-selected-navigation-item sunken-menu-item" data-hotkey="g c" data-selected-links="repo_source repo_downloads repo_commits repo_releases repo_tags repo_branches /TelerikAcademy/CSharp-Part-1">
        <span class="octicon octicon-code"></span> <span class="full-word">Code</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

      <li class="tooltipped tooltipped-w" aria-label="Issues">
        <a href="/TelerikAcademy/CSharp-Part-1/issues" aria-label="Issues" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g i" data-selected-links="repo_issues repo_labels repo_milestones /TelerikAcademy/CSharp-Part-1/issues">
          <span class="octicon octicon-issue-opened"></span> <span class="full-word">Issues</span>
          <span class="js-issue-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>      </li>

    <li class="tooltipped tooltipped-w" aria-label="Pull requests">
      <a href="/TelerikAcademy/CSharp-Part-1/pulls" aria-label="Pull requests" class="js-selected-navigation-item sunken-menu-item" data-hotkey="g p" data-selected-links="repo_pulls /TelerikAcademy/CSharp-Part-1/pulls">
          <span class="octicon octicon-git-pull-request"></span> <span class="full-word">Pull requests</span>
          <span class="js-pull-replace-counter"></span>
          <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>


  </ul>
  <div class="sunken-menu-separator"></div>
  <ul class="sunken-menu-group">

    <li class="tooltipped tooltipped-w" aria-label="Pulse">
      <a href="/TelerikAcademy/CSharp-Part-1/pulse" aria-label="Pulse" class="js-selected-navigation-item sunken-menu-item" data-selected-links="pulse /TelerikAcademy/CSharp-Part-1/pulse">
        <span class="octicon octicon-pulse"></span> <span class="full-word">Pulse</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>

    <li class="tooltipped tooltipped-w" aria-label="Graphs">
      <a href="/TelerikAcademy/CSharp-Part-1/graphs" aria-label="Graphs" class="js-selected-navigation-item sunken-menu-item" data-selected-links="repo_graphs repo_contributors /TelerikAcademy/CSharp-Part-1/graphs">
        <span class="octicon octicon-graph"></span> <span class="full-word">Graphs</span>
        <img alt="" class="mini-loader" height="16" src="https://assets-cdn.github.com/assets/spinners/octocat-spinner-32-e513294efa576953719e4e2de888dd9cf929b7d62ed8d05f25e731d02452ab6c.gif" width="16" />
</a>    </li>
  </ul>


</nav>

              <div class="only-with-full-nav">
                  
<div class="clone-url open"
  data-protocol-type="http"
  data-url="/users/set_protocol?protocol_selector=http&amp;protocol_type=clone">
  <h3><span class="text-emphasized">HTTPS</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="ssh"
  data-url="/users/set_protocol?protocol_selector=ssh&amp;protocol_type=clone">
  <h3><span class="text-emphasized">SSH</span> clone URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="git@github.com:TelerikAcademy/CSharp-Part-1.git" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>

  
<div class="clone-url "
  data-protocol-type="subversion"
  data-url="/users/set_protocol?protocol_selector=subversion&amp;protocol_type=clone">
  <h3><span class="text-emphasized">Subversion</span> checkout URL</h3>
  <div class="input-group js-zeroclipboard-container">
    <input type="text" class="input-mini input-monospace js-url-field js-zeroclipboard-target"
           value="https://github.com/TelerikAcademy/CSharp-Part-1" readonly="readonly">
    <span class="input-group-button">
      <button aria-label="Copy to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
    </span>
  </div>
</div>



<p class="clone-options">You can clone with
  <a href="#" class="js-clone-selector" data-protocol="http">HTTPS</a>, <a href="#" class="js-clone-selector" data-protocol="ssh">SSH</a>, or <a href="#" class="js-clone-selector" data-protocol="subversion">Subversion</a>.
  <a href="https://help.github.com/articles/which-remote-url-should-i-use" class="help tooltipped tooltipped-n" aria-label="Get help on which URL is right for you.">
    <span class="octicon octicon-question"></span>
  </a>
</p>


  <a href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1" class="btn btn-sm sidebar-button" title="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop." aria-label="Save TelerikAcademy/CSharp-Part-1 to your computer and use it in GitHub Desktop.">
    <span class="octicon octicon-device-desktop"></span>
    Clone in Desktop
  </a>

                <a href="/TelerikAcademy/CSharp-Part-1/archive/master.zip"
                   class="btn btn-sm sidebar-button"
                   aria-label="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   title="Download the contents of TelerikAcademy/CSharp-Part-1 as a zip file"
                   rel="nofollow">
                  <span class="octicon octicon-cloud-download"></span>
                  Download ZIP
                </a>
              </div>
        </div><!-- /.repository-sidebar -->

        <div id="js-repo-pjax-container" class="repository-content context-loader-container" data-pjax-container>
          

<a href="/TelerikAcademy/CSharp-Part-1/blob/0014f02cd450ad30ac68c34bd467e70367a773a9/6.%20Loops/README.md" class="hidden js-permalink-shortcut" data-hotkey="y">Permalink</a>

<!-- blob contrib key: blob_contributors:v21:0e3647e097677e0bcc4d934d8eb7efd3 -->

<div class="file-navigation js-zeroclipboard-container">
  
<div class="select-menu js-menu-container js-select-menu left">
  <span class="btn btn-sm select-menu-button js-menu-target css-truncate" data-hotkey="w"
    data-master-branch="master"
    data-ref="master"
    title="master"
    role="button" aria-label="Switch branches or tags" tabindex="0" aria-haspopup="true">
    <span class="octicon octicon-git-branch"></span>
    <i>branch:</i>
    <span class="js-select-button css-truncate-target">master</span>
  </span>

  <div class="select-menu-modal-holder js-menu-content js-navigation-container" data-pjax aria-hidden="true">

    <div class="select-menu-modal">
      <div class="select-menu-header">
        <span class="select-menu-title">Switch branches/tags</span>
        <span class="octicon octicon-x js-menu-close" role="button" aria-label="Close"></span>
      </div>

      <div class="select-menu-filters">
        <div class="select-menu-text-filter">
          <input type="text" aria-label="Filter branches/tags" id="context-commitish-filter-field" class="js-filterable-field js-navigation-enable" placeholder="Filter branches/tags">
        </div>
        <div class="select-menu-tabs">
          <ul>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="branches" data-filter-placeholder="Filter branches/tags" class="js-select-menu-tab">Branches</a>
            </li>
            <li class="select-menu-tab">
              <a href="#" data-tab-filter="tags" data-filter-placeholder="Find a tag…" class="js-select-menu-tab">Tags</a>
            </li>
          </ul>
        </div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="branches">

        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


            <a class="select-menu-item js-navigation-item js-navigation-open selected"
               href="/TelerikAcademy/CSharp-Part-1/blob/master/6.%20Loops/README.md"
               data-name="master"
               data-skip-pjax="true"
               rel="nofollow">
              <span class="select-menu-item-icon octicon octicon-check"></span>
              <span class="select-menu-item-text css-truncate-target" title="master">
                master
              </span>
            </a>
        </div>

          <div class="select-menu-no-results">Nothing to show</div>
      </div>

      <div class="select-menu-list select-menu-tab-bucket js-select-menu-tab-bucket" data-tab-filter="tags">
        <div data-filterable-for="context-commitish-filter-field" data-filterable-type="substring">


        </div>

        <div class="select-menu-no-results">Nothing to show</div>
      </div>

    </div>
  </div>
</div>

  <div class="btn-group right">
    <a href="/TelerikAcademy/CSharp-Part-1/find/master"
          class="js-show-file-finder btn btn-sm empty-icon tooltipped tooltipped-s"
          data-pjax
          data-hotkey="t"
          aria-label="Quickly jump between files">
      <span class="octicon octicon-list-unordered"></span>
    </a>
    <button aria-label="Copy file path to clipboard" class="js-zeroclipboard btn btn-sm zeroclipboard-button" data-copied-hint="Copied!" type="button"><span class="octicon octicon-clippy"></span></button>
  </div>

  <div class="breadcrumb js-zeroclipboard-target">
    <span class='repo-root js-repo-root'><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">CSharp-Part-1</span></a></span></span><span class="separator">/</span><span itemscope="" itemtype="http://data-vocabulary.org/Breadcrumb"><a href="/TelerikAcademy/CSharp-Part-1/tree/master/6.%20Loops" class="" data-branch="master" data-direction="back" data-pjax="true" itemscope="url"><span itemprop="title">6. Loops</span></a></span><span class="separator">/</span><strong class="final-path">README.md</strong>
  </div>
</div>


  <div class="commit file-history-tease">
    <div class="file-history-tease-header">
        <img alt="evlogihr" class="avatar" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
        <span class="author"><a href="/evlogihr" rel="contributor">evlogihr</a></span>
        <time datetime="2015-02-05T08:37:09Z" is="relative-time">Feb 5, 2015</time>
        <div class="commit-title">
            <a href="/TelerikAcademy/CSharp-Part-1/commit/0014f02cd450ad30ac68c34bd467e70367a773a9" class="message" data-pjax="true" title="Fixed Problem 3.">Fixed Problem 3.</a>
        </div>
    </div>

    <div class="participation">
      <p class="quickstat">
        <a href="#blob_contributors_box" rel="facebox">
          <strong>4</strong>
           contributors
        </a>
      </p>
          <a class="avatar-link tooltipped tooltipped-s" aria-label="evlogihr" href="/TelerikAcademy/CSharp-Part-1/commits/master/6.%20Loops/README.md?author=evlogihr"><img alt="evlogihr" class="avatar" data-user="3619393" height="20" src="https://avatars3.githubusercontent.com/u/3619393?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="GoranGit" href="/TelerikAcademy/CSharp-Part-1/commits/master/6.%20Loops/README.md?author=GoranGit"><img alt="GoranGit" class="avatar" data-user="3930766" height="20" src="https://avatars2.githubusercontent.com/u/3930766?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="wnvko" href="/TelerikAcademy/CSharp-Part-1/commits/master/6.%20Loops/README.md?author=wnvko"><img alt="Milko Venkov" class="avatar" data-user="5990334" height="20" src="https://avatars1.githubusercontent.com/u/5990334?v=3&amp;s=40" width="20" /></a>
    <a class="avatar-link tooltipped tooltipped-s" aria-label="NikolayIT" href="/TelerikAcademy/CSharp-Part-1/commits/master/6.%20Loops/README.md?author=NikolayIT"><img alt="Nikolay Kostov" class="avatar" data-user="3106986" height="20" src="https://avatars3.githubusercontent.com/u/3106986?v=3&amp;s=40" width="20" /></a>


    </div>
    <div id="blob_contributors_box" style="display:none">
      <h2 class="facebox-header">Users who have contributed to this file</h2>
      <ul class="facebox-user-list">
          <li class="facebox-user-list-item">
            <img alt="evlogihr" data-user="3619393" height="24" src="https://avatars1.githubusercontent.com/u/3619393?v=3&amp;s=48" width="24" />
            <a href="/evlogihr">evlogihr</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="GoranGit" data-user="3930766" height="24" src="https://avatars0.githubusercontent.com/u/3930766?v=3&amp;s=48" width="24" />
            <a href="/GoranGit">GoranGit</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Milko Venkov" data-user="5990334" height="24" src="https://avatars3.githubusercontent.com/u/5990334?v=3&amp;s=48" width="24" />
            <a href="/wnvko">wnvko</a>
          </li>
          <li class="facebox-user-list-item">
            <img alt="Nikolay Kostov" data-user="3106986" height="24" src="https://avatars1.githubusercontent.com/u/3106986?v=3&amp;s=48" width="24" />
            <a href="/NikolayIT">NikolayIT</a>
          </li>
      </ul>
    </div>
  </div>

<div class="file">
  <div class="file-header">
    <div class="file-actions">

      <div class="btn-group">
        <a href="/TelerikAcademy/CSharp-Part-1/raw/master/6.%20Loops/README.md" class="btn btn-sm " id="raw-url">Raw</a>
          <a href="/TelerikAcademy/CSharp-Part-1/blame/master/6.%20Loops/README.md" class="btn btn-sm js-update-url-with-hash">Blame</a>
        <a href="/TelerikAcademy/CSharp-Part-1/commits/master/6.%20Loops/README.md" class="btn btn-sm " rel="nofollow">History</a>
      </div>

        <a class="octicon-btn tooltipped tooltipped-nw"
           href="github-windows://openRepo/https://github.com/TelerikAcademy/CSharp-Part-1?branch=master&amp;filepath=6.%20Loops%2FREADME.md"
           aria-label="Open this file in GitHub for Windows">
            <span class="octicon octicon-device-desktop"></span>
        </a>

            <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/edit/master/6.%20Loops/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="NJBIHBtNKp9wL97upoQplxDRs6sa+m+coQ1MnfavCw+VdJI93PAdqMZw4211km9MUbjyGPNUxJXo1gUJZnRVeA==" /></div>
              <button class="octicon-btn tooltipped tooltipped-n" type="submit" aria-label="Clicking this button will fork this project so you can edit the file" data-hotkey="e" data-disable-with>
                <span class="octicon octicon-pencil"></span>
              </button>
</form>
          <form accept-charset="UTF-8" action="/TelerikAcademy/CSharp-Part-1/delete/master/6.%20Loops/README.md" class="inline-form" method="post"><div style="margin:0;padding:0;display:inline"><input name="utf8" type="hidden" value="&#x2713;" /><input name="authenticity_token" type="hidden" value="sLGPgN0pnAkzteLjjh6uXRTgXFiu2cx66QB4U6tfY91oxAw1l4JE/VsdvWGVK8+ZrgVc0RkLQS5xDTjntEyMVQ==" /></div>
            <button class="octicon-btn octicon-btn-danger tooltipped tooltipped-n" type="submit" aria-label="Fork this project and delete file" data-disable-with>
              <span class="octicon octicon-trashcan"></span>
            </button>
</form>    </div>

    <div class="file-info">
        254 lines (190 sloc)
        <span class="file-info-divider"></span>
      9.92 kb
    </div>
  </div>
    <div id="readme" class="blob instapaper_body">
    <article class="markdown-body entry-content" itemprop="mainContentOfPage"><h1>
<a id="user-content-homework-loops" class="anchor" href="#homework-loops" aria-hidden="true"><span class="octicon octicon-link"></span></a>Homework: Loops</h1>

<h3>
<a id="user-content-problem-1--numbers-from-1-to-n" class="anchor" href="#problem-1--numbers-from-1-to-n" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 1.  Numbers from 1 to N</h3>

<ul class="task-list">
<li>  Write a program that enters from the console a positive integer <code>n</code> and prints all the numbers from <code>1</code> to <code>n</code>, on a single line, separated by a space.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>output</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>1 2 3</td>
</tr>
<tr>
<td>5</td>
<td>1 2 3 4 5</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-2--numbers-not-divisible-by-3-and-7" class="anchor" href="#problem-2--numbers-not-divisible-by-3-and-7" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 2.  Numbers Not Divisible by 3 and 7</h3>

<ul class="task-list">
<li>  Write a program that enters from the console a positive integer <code>n</code> and prints all the numbers from <code>1</code> to <code>n</code> not divisible by <code>3</code> or <code>7</code>, on a single line, separated by a space.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>output</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>1 2</td>
</tr>
<tr>
<td>10</td>
<td>1 2 4 5 8 10</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-3--min-max-sum-and-average-of-n-numbers" class="anchor" href="#problem-3--min-max-sum-and-average-of-n-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 3.  Min, Max, Sum and Average of N Numbers</h3>

<ul class="task-list">
<li>  Write a program that reads from the console a sequence of <code>n</code> integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).</li>
<li>  The input starts by the number <code>n</code> (alone in a line) followed by <code>n</code> lines, each holding an integer number.</li>
<li>  The output is like in the examples below.</li>
</ul>

<p><em>Example 1:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>output</th>
</tr>
</thead>
<tbody>
<tr>
<td>3 <br> 2 <br> 5 <br> 1</td>
<td>min = 1 <br> max = 5 <br> sum = 8 <br> avg = 2.67</td>
</tr>
</tbody>
</table>

<p><em>Example 2:</em></p>

<table>
<thead>
<tr>
<th>input</th>
<th>output</th>
</tr>
</thead>
<tbody>
<tr>
<td>2 <br> -1 <br> 4</td>
<td>min = -1 <br> max = 4 <br> sum = 3 <br> avg = 1.50</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-4--print-a-deck-of-52-cards" class="anchor" href="#problem-4--print-a-deck-of-52-cards" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 4.  Print a Deck of 52 Cards</h3>

<ul class="task-list">
<li>  Write a program that generates and prints all possible cards from a <a href="http://en.wikipedia.org/wiki/Standard_52-card_deck">standard deck of 52 cards</a> (without the jokers).
The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

<ul class="task-list">
<li>  The card faces should start from 2 to A.</li>
<li>  Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
Use 2 nested for-loops and a switch-case statement.</li>
</ul>
</li>
</ul>

<p><em>output</em></p>

<pre><code>2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds
</code></pre>

<p><em>Note: You may use the suit symbols instead of text.</em></p>

<h3>
<a id="user-content-problem-5--calculate-1--1x--2x2----nxn" class="anchor" href="#problem-5--calculate-1--1x--2x2----nxn" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 5.  Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N</h3>

<ul class="task-list">
<li>  Write a program that, for a given two integer numbers <code>n</code> and <code>x</code>, calculates the sum <code>S = 1 + 1!/x + 2!/x2 + … + n!/x^n</code>.</li>
<li>  Use only one loop. Print the result with <code>5</code> digits after the decimal point.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>x</th>
<th>S</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>2</td>
<td>2.75000</td>
</tr>
<tr>
<td>4</td>
<td>3</td>
<td>2.07407</td>
</tr>
<tr>
<td>5</td>
<td>-4</td>
<td>0.75781</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-6--calculate-n--k" class="anchor" href="#problem-6--calculate-n--k" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 6.  Calculate N! / K!</h3>

<ul class="task-list">
<li>  Write a program that calculates <code>n! / k!</code> for given <code>n</code> and <code>k</code> (1 &lt; k &lt; n &lt; 100).</li>
<li>  Use only one loop.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>k</th>
<th>n! / k!</th>
</tr>
</thead>
<tbody>
<tr>
<td>5</td>
<td>2</td>
<td>60</td>
</tr>
<tr>
<td>6</td>
<td>5</td>
<td>6</td>
</tr>
<tr>
<td>8</td>
<td>3</td>
<td>6720</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-7--calculate-n--k--n-k" class="anchor" href="#problem-7--calculate-n--k--n-k" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 7.  Calculate N! / (K! * (N-K)!)</h3>

<ul class="task-list">
<li>  In combinatorics, the number of ways to choose <code>k</code> different members out of a group of <code>n</code> different elements (also known as the number of combinations) is calculated by the following formula:
<a href="https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png" target="_blank"><img src="https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png" alt="formula" style="max-width:100%;"></a>
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.</li>
<li>  Your task is to write a program that calculates <code>n! / (k! * (n-k)!)</code> for given <code>n</code> and <code>k</code> (1 &lt; k &lt; n &lt; 100). Try to use only two loops.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>k</th>
<th>n! / (k! * (n-k)!)</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>2</td>
<td>3</td>
</tr>
<tr>
<td>4</td>
<td>2</td>
<td>6</td>
</tr>
<tr>
<td>10</td>
<td>6</td>
<td>210</td>
</tr>
<tr>
<td>52</td>
<td>5</td>
<td>2598960</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-8--catalan-numbers" class="anchor" href="#problem-8--catalan-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 8.  Catalan Numbers</h3>

<ul class="task-list">
<li>  In combinatorics, the Catalan numbers are calculated by the following formula:
<a href="https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png" target="_blank"><img src="https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png" alt="catalan-formula" style="max-width:100%;"></a>
</li>
<li>  Write a program to calculate the <code>n</code><sup><code>th</code></sup> Catalan number by given <code>n</code> (0 ≤ n ≤ 100). </li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>Catalan(n)</th>
</tr>
</thead>
<tbody>
<tr>
<td>0</td>
<td>1</td>
</tr>
<tr>
<td>5</td>
<td>42</td>
</tr>
<tr>
<td>10</td>
<td>16796</td>
</tr>
<tr>
<td>15</td>
<td>9694845</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-9--matrix-of-numbers" class="anchor" href="#problem-9--matrix-of-numbers" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 9.  Matrix of Numbers</h3>

<ul class="task-list">
<li>  Write a program that reads from the console a positive integer number <code>n</code> (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.</li>
</ul>

<p><em>Examples:</em></p>

<pre><code>n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
</code></pre>

<h3>
<a id="user-content-problem-10-odd-and-even-product" class="anchor" href="#problem-10-odd-and-even-product" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 10. Odd and Even Product</h3>

<ul class="task-list">
<li>  You are given <code>n</code> integers (given in a single line, separated by a space).</li>
<li>  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.</li>
<li>  Elements are counted from <code>1</code> to <code>n</code>, so the first element is odd, the second is even, etc.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>numbers</th>
<th>result</th>
</tr>
</thead>
<tbody>
<tr>
<td>2 1 1 6 3</td>
<td>yes</td>
</tr>
<tr>
<td>product = 6</td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td>3 10 4 6 5 1</td>
<td>yes</td>
</tr>
<tr>
<td>product = 60</td>
<td></td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td>4 3 2 5 2</td>
<td>no</td>
</tr>
<tr>
<td>odd_product = 16</td>
<td></td>
</tr>
<tr>
<td>even_product = 15</td>
<td></td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-11-random-numbers-in-given-range" class="anchor" href="#problem-11-random-numbers-in-given-range" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 11. Random Numbers in Given Range</h3>

<ul class="task-list">
<li>  Write a program that enters <code>3</code> integers <code>n</code>, <code>min</code> and <code>max</code> (<code>min != max</code>) and prints <code>n</code> random numbers in the range <code>[min...max]</code>.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>min</th>
<th>max</th>
<th>random numbers</th>
</tr>
</thead>
<tbody>
<tr>
<td>5</td>
<td>0</td>
<td>1</td>
<td>1 0 0 1 1</td>
</tr>
<tr>
<td>10</td>
<td>10</td>
<td>15</td>
<td>12 14 12 15 10 12 14 13 13 11</td>
</tr>
</tbody>
</table>

<p><em>Note: The above output is just an example. Due to randomness, your program most probably will produce different results.</em></p>

<h3>
<a id="user-content-problem-12-randomize-the-numbers-1n" class="anchor" href="#problem-12-randomize-the-numbers-1n" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 12.* Randomize the Numbers 1…N</h3>

<ul class="task-list">
<li>  Write a program that enters in integer <code>n</code> and prints the numbers <code>1, 2, …, n</code> in random order.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>randomized numbers 1…n</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>2 1 3</td>
</tr>
<tr>
<td>10</td>
<td>3 4 8 2 6 7 9 1 10 5</td>
</tr>
</tbody>
</table>

<p><em>Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.</em></p>

<h3>
<a id="user-content-problem-13-binary-to-decimal-number" class="anchor" href="#problem-13-binary-to-decimal-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 13. Binary to Decimal Number</h3>

<ul class="task-list">
<li>  Using loops write a program that converts a binary integer number to its decimal form.</li>
<li>  The input is entered as string. The output should be a variable of type long.</li>
<li>  Do not use the built-in .NET functionality.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>binary</th>
<th>decimal</th>
</tr>
</thead>
<tbody>
<tr>
<td>0</td>
<td>0</td>
</tr>
<tr>
<td>11</td>
<td>3</td>
</tr>
<tr>
<td>1010101010101011</td>
<td>43691</td>
</tr>
<tr>
<td>1110000110000101100101000000</td>
<td>236476736</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-14-decimal-to-binary-number" class="anchor" href="#problem-14-decimal-to-binary-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 14. Decimal to Binary Number</h3>

<ul class="task-list">
<li>  Using loops write a program that converts an integer number to its binary representation.</li>
<li>  The input is entered as long. The output should be a variable of type string.</li>
<li>  Do not use the built-in .NET functionality.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>decimal</th>
<th>binary</th>
</tr>
</thead>
<tbody>
<tr>
<td>0</td>
<td>0</td>
</tr>
<tr>
<td>3</td>
<td>11</td>
</tr>
<tr>
<td>43691</td>
<td>1010101010101011</td>
</tr>
<tr>
<td>236476736</td>
<td>1110000110000101100101000000</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-15-hexadecimal-to-decimal-number" class="anchor" href="#problem-15-hexadecimal-to-decimal-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 15. Hexadecimal to Decimal Number</h3>

<ul class="task-list">
<li>  Using loops write a program that converts a hexadecimal integer number to its decimal form.</li>
<li>  The input is entered as string. The output should be a variable of type long.</li>
<li>  Do not use the built-in .NET functionality.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>hexadecimal</th>
<th>decimal</th>
</tr>
</thead>
<tbody>
<tr>
<td>FE</td>
<td>254</td>
</tr>
<tr>
<td>1AE3</td>
<td>6883</td>
</tr>
<tr>
<td>4ED528CBB4</td>
<td>338583669684</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-16-decimal-to-hexadecimal-number" class="anchor" href="#problem-16-decimal-to-hexadecimal-number" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 16. Decimal to Hexadecimal Number</h3>

<ul class="task-list">
<li>  Using loops write a program that converts an integer number to its hexadecimal representation.</li>
<li>  The input is entered as long. The output should be a variable of type string.</li>
<li>  Do not use the built-in .NET functionality.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>decimal</th>
<th>hexadecimal</th>
</tr>
</thead>
<tbody>
<tr>
<td>254</td>
<td>FE</td>
</tr>
<tr>
<td>6883</td>
<td>1AE3</td>
</tr>
<tr>
<td>338583669684</td>
<td>4ED528CBB4</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-17-calculate-gcd" class="anchor" href="#problem-17-calculate-gcd" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 17.* Calculate GCD</h3>

<ul class="task-list">
<li>  Write a program that calculates the greatest common divisor (GCD) of given two integers <code>a</code> and <code>b</code>.</li>
<li>  Use the Euclidean algorithm (find it in Internet).</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>a</th>
<th>b</th>
<th>GCD(a, b)</th>
</tr>
</thead>
<tbody>
<tr>
<td>3</td>
<td>2</td>
<td>1</td>
</tr>
<tr>
<td>60</td>
<td>40</td>
<td>20</td>
</tr>
<tr>
<td>5</td>
<td>-15</td>
<td>5</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-18-trailing-zeroes-in-n" class="anchor" href="#problem-18-trailing-zeroes-in-n" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 18.* Trailing Zeroes in N!</h3>

<ul class="task-list">
<li>  Write a program that calculates with how many zeroes the factorial of a given number <code>n</code> has at its end.</li>
<li>  Your program should work well for very big numbers, e.g. <code>n=100000</code>.</li>
</ul>

<p><em>Examples:</em></p>

<table>
<thead>
<tr>
<th>n</th>
<th>trailing zeroes of n!</th>
<th>explaination</th>
</tr>
</thead>
<tbody>
<tr>
<td>10</td>
<td>2</td>
<td>3628800</td>
</tr>
<tr>
<td>20</td>
<td>4</td>
<td>2432902008176640000</td>
</tr>
<tr>
<td>100000</td>
<td>24999</td>
<td>think why</td>
</tr>
</tbody>
</table>

<h3>
<a id="user-content-problem-19-spiral-matrix" class="anchor" href="#problem-19-spiral-matrix" aria-hidden="true"><span class="octicon octicon-link"></span></a>Problem 19.** Spiral Matrix</h3>

<ul class="task-list">
<li>  Write a program that reads from the console a positive integer number <code>n</code> (1 ≤ n ≤ 20) and prints a matrix holding the numbers from <code>1</code> to <code>n*n</code> in the form of square spiral like in the examples below.</li>
</ul>

<p><em>Examples:</em></p>

<pre><code>n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1  2  3  4
        4 3                 8 9 4               12 13 14 5
                            7 6 5               11 16 15 6
                                                10 9  8  7
</code></pre>
</article>
  </div>

</div>

<a href="#jump-to-line" rel="facebox[.linejump]" data-hotkey="l" style="display:none">Jump to Line</a>
<div id="jump-to-line" style="display:none">
  <form accept-charset="UTF-8" class="js-jump-to-line-form">
    <input class="linejump-input js-jump-to-line-field" type="text" placeholder="Jump to line&hellip;" autofocus>
    <button type="submit" class="btn">Go</button>
  </form>
</div>

        </div>

      </div><!-- /.repo-container -->
      <div class="modal-backdrop"></div>
    </div><!-- /.container -->
  </div><!-- /.site -->


    </div><!-- /.wrapper -->

      <div class="container">
  <div class="site-footer" role="contentinfo">
    <ul class="site-footer-links right">
        <li><a href="https://status.github.com/" data-ga-click="Footer, go to status, text:status">Status</a></li>
      <li><a href="https://developer.github.com" data-ga-click="Footer, go to api, text:api">API</a></li>
      <li><a href="https://training.github.com" data-ga-click="Footer, go to training, text:training">Training</a></li>
      <li><a href="https://shop.github.com" data-ga-click="Footer, go to shop, text:shop">Shop</a></li>
        <li><a href="https://github.com/blog" data-ga-click="Footer, go to blog, text:blog">Blog</a></li>
        <li><a href="https://github.com/about" data-ga-click="Footer, go to about, text:about">About</a></li>

    </ul>

    <a href="https://github.com" aria-label="Homepage">
      <span class="mega-octicon octicon-mark-github" title="GitHub"></span>
</a>
    <ul class="site-footer-links">
      <li>&copy; 2015 <span title="0.04768s from github-fe142-cp1-prd.iad.github.net">GitHub</span>, Inc.</li>
        <li><a href="https://github.com/site/terms" data-ga-click="Footer, go to terms, text:terms">Terms</a></li>
        <li><a href="https://github.com/site/privacy" data-ga-click="Footer, go to privacy, text:privacy">Privacy</a></li>
        <li><a href="https://github.com/security" data-ga-click="Footer, go to security, text:security">Security</a></li>
        <li><a href="https://github.com/contact" data-ga-click="Footer, go to contact, text:contact">Contact</a></li>
    </ul>
  </div>
</div>


    <div class="fullscreen-overlay js-fullscreen-overlay" id="fullscreen_overlay">
  <div class="fullscreen-container js-suggester-container">
    <div class="textarea-wrap">
      <textarea name="fullscreen-contents" id="fullscreen-contents" class="fullscreen-contents js-fullscreen-contents" placeholder=""></textarea>
      <div class="suggester-container">
        <div class="suggester fullscreen-suggester js-suggester js-navigation-container"></div>
      </div>
    </div>
  </div>
  <div class="fullscreen-sidebar">
    <a href="#" class="exit-fullscreen js-exit-fullscreen tooltipped tooltipped-w" aria-label="Exit Zen Mode">
      <span class="mega-octicon octicon-screen-normal"></span>
    </a>
    <a href="#" class="theme-switcher js-theme-switcher tooltipped tooltipped-w"
      aria-label="Switch themes">
      <span class="octicon octicon-color-mode"></span>
    </a>
  </div>
</div>



    
    

    <div id="ajax-error-message" class="flash flash-error">
      <span class="octicon octicon-alert"></span>
      <a href="#" class="octicon octicon-x flash-close js-ajax-error-dismiss" aria-label="Dismiss error"></a>
      Something went wrong with that request. Please try again.
    </div>


      <script crossorigin="anonymous" src="https://assets-cdn.github.com/assets/frameworks-d22b59d0085e83b7549ba4341ec9e68f80c2f29c8e49213ee182003dc8d568c6.js"></script>
      <script async="async" crossorigin="anonymous" src="https://assets-cdn.github.com/assets/github-0bc0f45c838b5d9d25bc071d2a4b0abe759a093392087dce55cd2caa00ea4f36.js"></script>
      
      

  </body>
</html>

